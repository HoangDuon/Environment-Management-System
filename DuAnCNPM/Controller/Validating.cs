using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DuAnCNPM.Controller;
using DuAnCNPM.Datas;
using DuAnCNPM.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DuAnCNPM.Controlers
{
    public class Validating
    {
        public Validating() { }
        public bool[] valSignin(string Name, string Password)
        {
            bool nameValid = string.IsNullOrWhiteSpace(Name) &&
                     !Regex.IsMatch(Name, @"^[a-zA-Z][a-zA-Z0-9]*$");

            bool passwordValid = string.IsNullOrWhiteSpace(Password);

            return new bool[] { nameValid, passwordValid };
        }

        public bool[] valResetPassword(string Pass, string PassNew)
        {
            bool PassValid = !string.IsNullOrWhiteSpace(Pass) &&
             Regex.IsMatch(Pass, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{6,}$"); ;
            bool PassNewValid = !string.IsNullOrWhiteSpace(Pass) &&
             Regex.IsMatch(Pass, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{6,}$"); ;
            bool BothPass = (Pass == PassNew);
            return new bool[] { PassValid, PassNewValid, BothPass };
        }

        public bool[] valResetPasswordInner(string oldPass, string Pass, string PassNew)
        {
            bool OldPassValid = false;
            using (var db = new CTQLMTContext())
            {
                var nhanVien = db.NhanViens.FirstOrDefault(em => em.MA_NHAN_VIEN == UserInform.manhanvien);
                if (BCrypt.Net.BCrypt.Verify(oldPass, nhanVien.MAT_KHAU))
                {
                    OldPassValid = true;
                }
                ;
            }
            bool PassValid = !string.IsNullOrWhiteSpace(Pass) &&
             Regex.IsMatch(Pass, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{6,}$"); ;
            bool PassNewValid = !string.IsNullOrWhiteSpace(PassNew);
            bool BothPass = (Pass == PassNew);
            return new bool[] { OldPassValid, PassValid, PassNewValid, BothPass };
        }

        ///Checking OTP
        public bool valOTP(string OTP)
        {
            if (!string.IsNullOrWhiteSpace(OTP))
            {
                return true;
            }
            return false;
        }

        public bool EmailService(string email)
        {
            using (var db = new CTQLMTContext())
            {
                var nhanVien = db.NhanViens.FirstOrDefault(em => em.GMAIL == email);
                if (nhanVien != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public bool valEmail(string email)
        {
            using (var db = new CTQLMTContext())
            {
                var nhanVien = db.NhanViens.FirstOrDefault(em => em.GMAIL == email);
                if (nhanVien != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public bool[] addEmployeeValidating(DateTime NgaySinh, String MatKhau, String SDT, String Gmail)
        // ngay sinh nam trong khoang nao do 
        // mat khau tu 8 chu so, chu hoa, chu thuong va co it nhat 1 so 
        // gmail phai co ki tu @gmail.com
        // sdt mot chuoi gom 10 so 
        {
            // dam bao nhan vien du 18 tuoi
            DateTime present = DateTime.Today;
            int tuoi = 0;
            if (present < NgaySinh)
            {
                tuoi = present.Year - NgaySinh.Year - 1;
            }
            else
            {
                tuoi = present.Year - NgaySinh.Year;
            }
            bool checkNgaySinh = (tuoi >= 18);

            //Kiem tra mat khau
            bool checkMatKhau = Regex.IsMatch(MatKhau, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$");

            // kiem tra gmail
            bool checkGmail = validateGmail(Gmail);

            // kiem tra so dien thoai
            bool checkSDT = validatePhoneNumber(SDT);

            return new bool[] { checkNgaySinh, checkMatKhau, checkGmail, checkSDT };
        }

        //Danh sach nhung vi tri cua nhan vien
        public List<String> position()
        {
            return new List<String> { "PTN", "PKH", "PQT", "PKQ", "PKD", "ADMIN" };
        }

        // kiểm tra số điện thoại có phải là số 
        public Boolean validatePhoneNumber(String phoneNumber)
        {
            return phoneNumber.Length == 10 && phoneNumber.All(char.IsDigit);
        }

        // kiểm tra gmail có đúng địng dạng 
        public Boolean validateGmail(String gmail)
        {
            return gmail.EndsWith("@gmail.com", StringComparison.OrdinalIgnoreCase);
        }

        // Kiểm tra độ tuổi
        public Boolean ageValidate(DateTime ngaySinh)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - ngaySinh.Year;
            if (today.Month < ngaySinh.Month || (today.Month == ngaySinh.Month && today.Day < ngaySinh.Day))
            {
                age--;
            }
            return age >= 18;
        }

        public Boolean enviromentTypeValidate(String LoaiMoiTruong)
        {
            List<String> type = new List<String> { "DAT", "NUOC", "KHONGKHI", "KHITHAI" };
            if (!type.Contains(LoaiMoiTruong)) return false;
            return true;
        }

        // Kiếm tra dử liệu khi thêm một hợp đồng
        public Boolean IdCustomerValidate(String id)
        {
            using (var context = new CTQLMTContext())
            {
                var listKH = context.KhachHangs.ToList();
                foreach (KhachHang kh in listKH)
                {
                    if (kh.MA_CONG_TY == id) return true;
                }
            }
            return false;
        }

        // kiểm tra thời gian ký và giao hợp đồng có hợp lí không
        public Boolean timeValid(String NgayKy, String NgayTraKQ)
        {
            DateTime ngayky = DateTime.Parse(NgayKy);
            DateTime ngaygiao = DateTime.Parse(NgayTraKQ);
            return ngayky < ngaygiao;
        }

        // kiếm tra số tiền nhập vào có phải là số không
        public Boolean moneyValidate(String sotien)
        {
            long result = 0;
            if (!long.TryParse(sotien, out result)) return false;
            return result > 0;
        }

        // Kiểm tra chỉ số
        public Boolean indexValidate(String chiso)
        {
            float result = 0;
            if (!float.TryParse(chiso, out result))
            {
                return false;
            }
            return true;
        }

        // Kiểm tra tên nhập vào có đúng không 
        public Boolean nameValidate(String name)
        {
            if (string.IsNullOrWhiteSpace(name)) return false;
            return Regex.IsMatch(name, @"^[\p{L} ]+$");
        }

        // Kiểm tra ngày nhập vào 
        public Boolean dateValidate(String ngay)
        {
            DateTime dt = new DateTime();
            if (!DateTime.TryParseExact(ngay, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dt)) return false;
            else return true;
        }

        // kiểm tra giới tính
        public Boolean genderValidate(String gioitinh)
        {
            List<String> list = new List<string> { "Nam", "Nữ" };
            return list.Contains(gioitinh);
        }

        // kiểm tra tiêu chuẩn
        public Boolean standardValidate(String tieuchuan)
        {
            if (Decimal.TryParse(tieuchuan, out decimal value))
            {
                return true;
            }
            String[] arr = tieuchuan.Split('-');
            if (Decimal.TryParse(arr[0], out decimal value1) && Decimal.TryParse(arr[1], out decimal value2)) return true;
            return false;
        }

        //update
        //kiểm tra nơi nhập

        public List<String> enterPlacevalidate()
        {
            return new List<String> { "PTN", "HT" };
        }

        // dictionary các mã số thuế đã kí 
        public Dictionary<String, String> listMST()
        {
            Dictionary<String, String> result = new Dictionary<string, string>();
            using (var context = new CTQLMTContext())
            {
                var listKH = context.KhachHangs.ToList();
                foreach (KhachHang kh in listKH)
                {
                    result.Add(kh.MA_SO_THUE, kh.MA_CONG_TY);
                }
            }
            return result;
        }

        //xác  nhân hoàn thành hợp đồng
        public void isPerfect(String MaHopDong)
        {
            using (var context = new CTQLMTContext())
            {
                var listCS = context.ChiTietChiSos.ToList();
                List<ChiTietChiSo> listCTCS = new List<ChiTietChiSo>();
                foreach (ChiTietChiSo cs in listCS)
                {
                    if (cs.MA_HOP_DONG == MaHopDong)
                    {
                        listCTCS.Add(cs);
                    }
                }
                foreach (ChiTietChiSo cs in listCTCS)
                {
                    if (cs.FLAG != true)
                    {
                        context.HopDongs.Find(MaHopDong).HOAN_THANH = false;
                        return;
                    }
                }
                context.HopDongs.Find(MaHopDong).HOAN_THANH = true;
            }
        }

    }
}