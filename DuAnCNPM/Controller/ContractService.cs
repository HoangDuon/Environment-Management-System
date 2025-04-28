using DuAnCNPM.Controlers;
using DuAnCNPM.Datas;
using DuAnCNPM.Models;
using Siticone.Desktop.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace DuAnCNPM.Controller
{
    class ContractService
    {
        public ContractService() { }

        //tu dong phat sinh ma hop dong
        private String generateContractID()
        {
            int count = 0;
            using (var context = new CTQLMTContext())
            {
                if (context.HopDongs.Count() == 0)
                {
                    count = 1;
                }
                else
                {
                    int[] stt = new int[context.HopDongs.Count()];
                    List<HopDong> listHD = context.HopDongs.ToList();
                    int i = 0;
                    foreach (HopDong hd in listHD)
                    {
                        stt[i] = int.Parse(hd.MA_HOP_DONG.Substring(2));
                        i++;
                    }
                    count = stt.Max() + 1;
                }
            }
            String result = "HD" + count.ToString();
            return result;
        }

        //Them mot hop dong
        public Boolean addContract(String MaNhanVien, String MaCongTy, DateTime NgayKy, DateTime NgayTraKQ, long SoTien)
        {
            //// kiem tra du lieu thoi gian
            //Validating validate = new Validating();
            //if (!validate.timeValid(NgayKy, NgayTraKQ)) return false;

            String mahopdong;

            using (var context = new CTQLMTContext())
            {
                // check nhan vien phai ton tai
                var nhanvien = context.NhanViens.Find(MaNhanVien);
                if (nhanvien == null) return false;

                var khachhang = context.KhachHangs.Find(MaCongTy);
                if (khachhang == null) return false;

                // hop dong duoc tao
                mahopdong = generateContractID();
                var hopdong = new HopDong
                {
                    MA_HOP_DONG = mahopdong,
                    MA_NHAN_VIEN = MaNhanVien,
                    MA_CONG_TY = MaCongTy,
                    NGAY_KY = NgayKy,
                    NGAY_TRA_KQ = NgayTraKQ,
                    SO_TIEN = SoTien,
                    TRANG_THAI = true,
                    HOAN_THANH = false,
                    QUY = ((NgayKy.Month - 1) / 3 + 1).ToString() + "/" + NgayKy.Year.ToString()
                };
                context.HopDongs.Add(hopdong);
                context.SaveChanges();
            }
            using (var context = new CTQLMTContext())
            {
                // khi hop dong duoc tao thi cac chi tiet chi so se duoc tu dong tao voi chi so mac dinh la 0
                // user chi can goi lenh de chinh sua chi so
                var ListChiSoMoiTruong = context.ChiSoMoiTruongs.ToList();
                var chitietService = new DetailedIndexService();
                foreach (var chiso in ListChiSoMoiTruong)
                {
                    if (chiso.TRANG_THAI == true)
                    {
                        chitietService.addDetailedIndex(mahopdong, chiso.MA_CHI_SO, MaNhanVien, -1.0f, DateTime.Today, "");  //update
                    }
                }
            }
            return true;
        }

        //Xoa mot hop dong
        public Boolean deleteContract(String MaHopDong)
        {
            using (var context = new CTQLMTContext())
            {
                // tim hop dong can xoa 
                var hopdong = context.HopDongs.Find(MaHopDong);
                if (hopdong == null) return false;

                //xoa hop dong 
                hopdong.TRANG_THAI = false;  // update
                context.SaveChanges();
            }
            return true;
        }
        // chinh sua ma cong ty ky hop dong
        public Boolean editMacongty(String MaHopDong, String macongty)
        {
            using (var context = new CTQLMTContext())
            {
                var hopdong = context.HopDongs.Find(MaHopDong);
                if (hopdong == null) return false;
                hopdong.MA_CONG_TY = macongty;
                context.SaveChanges();
            }
            return true;
        }

        //chinh sua ngay ky hop dong
        public Boolean editNgayKy(String MaHopDong, DateTime NgayKy)
        {
            using (var context = new CTQLMTContext())
            {
                var hopdong = context.HopDongs.Find(MaHopDong);
                if (hopdong == null) return false;
                if (NgayKy > hopdong.NGAY_TRA_KQ) return false;
                hopdong.NGAY_KY = NgayKy;
                context.SaveChanges();
            }
            return true;
        }

        // chinh sua ngay tra kq cho hop dong
        public Boolean editNgayTra(String MaHopDong, DateTime NgayTraKQ)
        {
            using (var context = new CTQLMTContext())
            {
                var hopdong = context.HopDongs.Find(MaHopDong);
                if (hopdong == null) return false;
                if (NgayTraKQ < hopdong.NGAY_KY) return false;
                hopdong.NGAY_TRA_KQ = NgayTraKQ;
                context.SaveChanges();
            }
            return true;
        }

        // chinh sua gia tri cua hop dong
        public Boolean editSoTien(String MaHopDong, long SoTien)
        {
            if (SoTien < 0) return false;
            using (var context = new CTQLMTContext())
            {
                var hopdong = context.HopDongs.Find(MaHopDong);
                if (hopdong == null) return false;
                hopdong.SO_TIEN = SoTien;
                context.SaveChanges();
            }
            return true;
        }

        // search 
        // tim kiếm hợp đồng theo mã hợp đồng hoặc theo tên công ty, mã công ty đã kí 
        //data search name
        // tìm kiếm hợp đồng theo tên công ty
        private List<KhachHang> searchByCustomerName(String text)
        {
            if (text == null) return new List<KhachHang>();
            CustomerService listResult = new CustomerService();
            return listResult.searchCustomer(text);
        }
        // tìm kiếm hợp đồng theo mã hợp đồng
        private bool checkTextIsContractID(String text)
        {
            if (string.IsNullOrWhiteSpace(text) || text.Length <= 2) return false;
            List<String> sample = new List<String>() { "HD" };
            String final = text.Substring(2);      // lấy stt
            String first = text.Substring(0, 2);   // lấy 2 kí tự đầu
            bool checkFinal = sample.Contains(first);
            bool checkFirst = int.TryParse(final, out int result);
            if (checkFinal && checkFirst) return true;
            return false;
        }

        // tìm kiếm cho admin
        public List<HopDong> searchContract(String text)
        {
            List<HopDong> result = new List<HopDong>();
            if (string.IsNullOrWhiteSpace(text)) return result;
            // Phân tích chuỗi truyền vào là mã chỉ số
            if (checkTextIsContractID(text.Trim()))
            {
                using (var context = new CTQLMTContext())
                {
                    var hd = context.HopDongs.Find(text.Trim());
                    if (hd == null)
                        return result;
                    else
                    {
                        result.Add(hd);
                    }
                }
                return result;
            }
            // phân tích chuỗi truyền vào là tên khách hàng
            else
            {
                List<KhachHang> listKH = searchByCustomerName(text.Trim());
                List<String> listMaKH = new List<string>();
                foreach (KhachHang kh in listKH)
                {
                    if (kh != null)
                    {
                        listMaKH.Add(kh.MA_CONG_TY);
                    }
                }
                using (var context = new CTQLMTContext())
                {
                    var listHD = context.HopDongs.ToList();
                    foreach (HopDong hd in listHD)
                    {
                        if (listMaKH.Contains(hd.MA_CONG_TY))
                        {
                            result.Add(hd);
                        }
                    }
                }
                return result;
            }
        }

        // tìm kiếm cho nhân viên
        public List<HopDong> searchContractForEmployee(String text)
        {
            List<HopDong> result = new List<HopDong>();
            List<HopDong> temp = searchContract(text.Trim());
            foreach (HopDong hd in temp)
            {
                if (hd.TRANG_THAI == true)
                {
                    result.Add(hd);
                }
            }
            return result;
        }


        //sort
        // kiem tra hop dong khi nao het han
        public double timeRemain(String mahopdong)
        {
            double epsDate = 0;
            using (var context = new CTQLMTContext())
            {
                var hopdong = context.HopDongs.Find(mahopdong);
                DateTime now = DateTime.Now;
                DateTime exp;
                if (hopdong.NGAY_TRA_KQ != null)
                {
                    exp = hopdong.NGAY_TRA_KQ.Value;
                }
                else exp = DateTime.Now;
                TimeSpan eps = exp - now;
                epsDate = eps.TotalDays;
            }
            return epsDate;
        }

        // tạo data cho số thứ tự mã hợp đồng
        public Dictionary<String, double> dataToSort()
        {
            Dictionary<String, double> dic = new Dictionary<String, double>();
            using (var context = new CTQLMTContext())
            {
                var listHD = context.HopDongs.ToList();
                foreach (HopDong nv in listHD)
                {
                    double stt = timeRemain(nv.MA_HOP_DONG);
                    if (stt > -1)
                    {
                        dic.Add(nv.MA_HOP_DONG, stt);
                    }
                }
            }
            return dic;
        }

        //sort hợp đồng
        public List<HopDong> sortContract()
        {
            List<HopDong> result = new List<HopDong>();
            Dictionary<String, double> dic = dataToSort();
            using (var context = new CTQLMTContext())
            {
                while (dic.Count != 0)
                {
                    var keyWithMinValue = dic.Aggregate((x, y) => x.Value < y.Value ? x : y).Key;
                    var hopdong = context.HopDongs.Find(keyWithMinValue);
                    if (hopdong != null && hopdong.TRANG_THAI == true)
                    {
                        result.Add(hopdong);
                    }
                    dic.Remove(keyWithMinValue);
                }
            }
            return result;
        }

        public void ShowContractsAdminSearch(List<HopDong> hopDongs,DuAnCNPM.Views.DoubleBufferedPanel container, Siticone.Desktop.UI.WinForms.SiticoneGradientPanel chitiet)
        {
            container.Controls.Clear();

            int yOffset = 10;
                foreach (var hd in hopDongs)
                {
                    var panel = new Siticone.Desktop.UI.WinForms.SiticoneGroupBox();
                    if (hd.TRANG_THAI == false)
                    {
                        panel.BorderColor = System.Drawing.Color.Salmon;
                        panel.BorderRadius = 18;
                        panel.BorderThickness = 4;
                        panel.CustomBorderColor = System.Drawing.Color.AliceBlue;
                        panel.CustomBorderThickness = new System.Windows.Forms.Padding(0);
                        panel.FillColor = System.Drawing.Color.Gainsboro;
                        panel.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
                        panel.ForeColor = System.Drawing.Color.Black;
                        panel.Location = new System.Drawing.Point(5, yOffset);
                        panel.Name = "grbHDnv1";
                        panel.Size = new System.Drawing.Size(container.Width - 20, 53);
                        panel.TabIndex = 11;
                        panel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                    }
                    else
                    {
                        panel.BorderColor = System.Drawing.Color.LightGray;
                        panel.BorderRadius = 18;
                        panel.BorderThickness = 2;
                        panel.CustomBorderColor = System.Drawing.Color.AliceBlue;
                        panel.CustomBorderThickness = new System.Windows.Forms.Padding(0);
                        panel.FillColor = System.Drawing.Color.Gainsboro;
                        panel.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
                        panel.ForeColor = System.Drawing.Color.Black;
                        panel.Location = new System.Drawing.Point(5, yOffset);
                        panel.Name = "grbHDnv1";
                        panel.Size = new System.Drawing.Size(container.Width - 20, 53);
                        panel.TabIndex = 11;
                        panel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                    }
                    int width = panel.Width - 20;
                    var lblNgayHetHan = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
                    lblNgayHetHan.BackColor = System.Drawing.Color.Gainsboro;
                    lblNgayHetHan.BorderColor = System.Drawing.Color.Empty;
                    lblNgayHetHan.BorderThickness = 0;
                    lblNgayHetHan.Cursor = System.Windows.Forms.Cursors.IBeam;
                    lblNgayHetHan.DefaultText = "Ngày hết hạn: " + hd.NGAY_TRA_KQ;
                    lblNgayHetHan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
                    lblNgayHetHan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
                    lblNgayHetHan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
                    lblNgayHetHan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
                    lblNgayHetHan.FillColor = System.Drawing.Color.Gainsboro;
                    lblNgayHetHan.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
                    lblNgayHetHan.ForeColor = System.Drawing.Color.Black;
                    lblNgayHetHan.Location = new System.Drawing.Point(11, 30);
                    lblNgayHetHan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
                    lblNgayHetHan.Name = "txtNgayhethannv1";
                    lblNgayHetHan.PasswordChar = '\0';
                    lblNgayHetHan.PlaceholderText = "";
                    lblNgayHetHan.ReadOnly = true;
                    lblNgayHetHan.SelectedText = "";
                    lblNgayHetHan.Size = new System.Drawing.Size(width, 18);
                    lblNgayHetHan.TabIndex = 1;
                    lblNgayHetHan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

                    var lblTieuDe = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
                    lblTieuDe.BackColor = System.Drawing.Color.Gainsboro;
                    lblTieuDe.BorderColor = System.Drawing.Color.Empty;
                    lblTieuDe.BorderThickness = 0;
                    lblTieuDe.Cursor = System.Windows.Forms.Cursors.IBeam;
                    lblTieuDe.DefaultText = hd.MA_HOP_DONG + "-" + hd.MA_CONG_TY;
                    lblTieuDe.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
                    lblTieuDe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
                    lblTieuDe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
                    lblTieuDe.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
                    lblTieuDe.FillColor = System.Drawing.Color.Gainsboro;
                    lblTieuDe.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
                    lblTieuDe.ForeColor = System.Drawing.Color.Black;
                    lblTieuDe.Location = new System.Drawing.Point(11, 8);
                    lblTieuDe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                    lblTieuDe.Name = "txtHDnv1";
                    lblTieuDe.PasswordChar = '\0';
                    lblTieuDe.PlaceholderText = "";
                    lblTieuDe.ReadOnly = true;
                    lblTieuDe.SelectedText = "";
                    lblTieuDe.Size = new System.Drawing.Size(width, 18);
                    lblTieuDe.TabIndex = 0;
                    lblTieuDe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

                    panel.Controls.Add(lblNgayHetHan);
                    panel.Controls.Add(lblTieuDe);

                    container.Controls.Add(panel);

                    panel.Click += (s, e) => ShowContractDetailAdmin(hd, chitiet);
                    lblTieuDe.Click += (s, e) => ShowContractDetailAdmin(hd, chitiet);
                    lblNgayHetHan.Click += (s, e) => ShowContractDetailAdmin(hd, chitiet);

                    panel.MouseEnter += (s, e) =>
                    {
                        panel.FillColor = Color.DarkGray;

                        lblTieuDe.FillColor = Color.DarkGray;
                        lblNgayHetHan.FillColor = Color.DarkGray;
                    };

                    panel.MouseLeave += (s, e) =>
                    {
                        panel.FillColor = Color.Gainsboro;

                        lblTieuDe.FillColor = Color.Gainsboro;
                        lblNgayHetHan.FillColor = Color.Gainsboro;

                    };

                    yOffset += panel.Height + 10;

                }
        }

        public void ShowContractsAdmin(DuAnCNPM.Views.DoubleBufferedPanel container, Siticone.Desktop.UI.WinForms.SiticoneGradientPanel chitiet)
        {
            container.Controls.Clear();

            int yOffset = 10;
            using (var context = new CTQLMTContext())
            {
                var hopDongs = context.HopDongs.ToList();
                foreach (var hd in hopDongs)
                {
                    var panel = new Siticone.Desktop.UI.WinForms.SiticoneGroupBox();
                    if (hd.TRANG_THAI == false)
                    {
                        panel.BorderColor = System.Drawing.Color.Salmon;
                        panel.BorderRadius = 18;
                        panel.BorderThickness = 4;
                        panel.CustomBorderColor = System.Drawing.Color.AliceBlue;
                        panel.CustomBorderThickness = new System.Windows.Forms.Padding(0);
                        panel.FillColor = System.Drawing.Color.Gainsboro;
                        panel.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
                        panel.ForeColor = System.Drawing.Color.Black;
                        panel.Location = new System.Drawing.Point(5, yOffset);
                        panel.Name = "grbHDnv1";
                        panel.Size = new System.Drawing.Size(container.Width - 20, 53);
                        panel.TabIndex = 11;
                        panel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                    }
                    else
                    {
                        panel.BorderColor = System.Drawing.Color.LightGray;
                        panel.BorderRadius = 18;
                        panel.BorderThickness = 2;
                        panel.CustomBorderColor = System.Drawing.Color.AliceBlue;
                        panel.CustomBorderThickness = new System.Windows.Forms.Padding(0);
                        panel.FillColor = System.Drawing.Color.Gainsboro;
                        panel.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
                        panel.ForeColor = System.Drawing.Color.Black;
                        panel.Location = new System.Drawing.Point(5, yOffset);
                        panel.Name = "grbHDnv1";
                        panel.Size = new System.Drawing.Size(container.Width - 20, 53);
                        panel.TabIndex = 11;
                        panel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                    }
                    int width = panel.Width - 20;
                    var lblNgayHetHan = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
                    lblNgayHetHan.BackColor = System.Drawing.Color.Gainsboro;
                    lblNgayHetHan.BorderColor = System.Drawing.Color.Empty;
                    lblNgayHetHan.BorderThickness = 0;
                    lblNgayHetHan.Cursor = System.Windows.Forms.Cursors.IBeam;
                    lblNgayHetHan.DefaultText = "Ngày hết hạn: " + hd.NGAY_TRA_KQ;
                    lblNgayHetHan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
                    lblNgayHetHan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
                    lblNgayHetHan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
                    lblNgayHetHan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
                    lblNgayHetHan.FillColor = System.Drawing.Color.Gainsboro;
                    lblNgayHetHan.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
                    lblNgayHetHan.ForeColor = System.Drawing.Color.Black;
                    lblNgayHetHan.Location = new System.Drawing.Point(11, 30);
                    lblNgayHetHan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
                    lblNgayHetHan.Name = "txtNgayhethannv1";
                    lblNgayHetHan.PasswordChar = '\0';
                    lblNgayHetHan.PlaceholderText = "";
                    lblNgayHetHan.ReadOnly = true;
                    lblNgayHetHan.SelectedText = "";
                    lblNgayHetHan.Size = new System.Drawing.Size(width, 18);
                    lblNgayHetHan.TabIndex = 1;
                    lblNgayHetHan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

                    var lblTieuDe = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
                    lblTieuDe.BackColor = System.Drawing.Color.Gainsboro;
                    lblTieuDe.BorderColor = System.Drawing.Color.Empty;
                    lblTieuDe.BorderThickness = 0;
                    lblTieuDe.Cursor = System.Windows.Forms.Cursors.IBeam;
                    lblTieuDe.DefaultText = hd.MA_HOP_DONG + "-" + hd.MA_CONG_TY;
                    lblTieuDe.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
                    lblTieuDe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
                    lblTieuDe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
                    lblTieuDe.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
                    lblTieuDe.FillColor = System.Drawing.Color.Gainsboro;
                    lblTieuDe.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
                    lblTieuDe.ForeColor = System.Drawing.Color.Black;
                    lblTieuDe.Location = new System.Drawing.Point(11, 8);
                    lblTieuDe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                    lblTieuDe.Name = "txtHDnv1";
                    lblTieuDe.PasswordChar = '\0';
                    lblTieuDe.PlaceholderText = "";
                    lblTieuDe.ReadOnly = true;
                    lblTieuDe.SelectedText = "";
                    lblTieuDe.Size = new System.Drawing.Size(width, 18);
                    lblTieuDe.TabIndex = 0;
                    lblTieuDe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

                    panel.Controls.Add(lblNgayHetHan);
                    panel.Controls.Add(lblTieuDe);

                    container.Controls.Add(panel);

                    panel.Click += (s, e) => ShowContractDetailAdmin(hd, chitiet);
                    lblTieuDe.Click += (s, e) => ShowContractDetailAdmin(hd, chitiet);
                    lblNgayHetHan.Click += (s, e) => ShowContractDetailAdmin(hd, chitiet);

                    panel.MouseEnter += (s, e) =>
                    {
                        panel.FillColor = Color.DarkGray;

                        lblTieuDe.FillColor = Color.DarkGray;
                        lblNgayHetHan.FillColor = Color.DarkGray;
                    };

                    panel.MouseLeave += (s, e) =>
                    {
                        panel.FillColor = Color.Gainsboro;

                        lblTieuDe.FillColor = Color.Gainsboro;
                        lblNgayHetHan.FillColor = Color.Gainsboro;

                    };

                    yOffset += panel.Height + 10;

                }
                }
            }

        private void ShowContractDetailAdmin(HopDong hd, Siticone.Desktop.UI.WinForms.SiticoneGradientPanel main)
        {
            Siticone.Desktop.UI.WinForms.SiticoneGradientPanel thongtinchiso = main.Controls["panCSchitiet"] as Siticone.Desktop.UI.WinForms.SiticoneGradientPanel;
            (main.Controls["dtpNgaytraKQQLHD"] as Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker).Value = DateTime.Parse(hd.NGAY_TRA_KQ.ToString());
            (main.Controls["dtpNgaykyQLHD"] as Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker).Value = DateTime.Parse(hd.NGAY_KY.ToString());
            (main.Controls["txtSotien"] as Siticone.Desktop.UI.WinForms.SiticoneTextBox).Text = hd.SO_TIEN.ToString();
            (main.Controls["txtMaHDQLHD"] as Siticone.Desktop.UI.WinForms.SiticoneTextBox).Text = hd.MA_HOP_DONG;
            (main.Controls["txtMaNVQLHD"] as Siticone.Desktop.UI.WinForms.SiticoneTextBox).Text = hd.MA_NHAN_VIEN;
            (main.Controls["txtMaCtyQLHD"] as Siticone.Desktop.UI.WinForms.SiticoneTextBox).Text = hd.MA_CONG_TY;
            (main.Parent.Controls["btnSuaHD"] as Siticone.Desktop.UI.WinForms.SiticoneButton).Enabled = true;
            (main.Parent.Controls["btnXoaHD"] as Siticone.Desktop.UI.WinForms.SiticoneButton).Enabled = false;
            (main.Parent.Controls["btnLuuHD"] as Siticone.Desktop.UI.WinForms.SiticoneButton).Enabled = false;
            (thongtinchiso.Controls["btnSuaChiSoChiTiet"] as Siticone.Desktop.UI.WinForms.SiticoneButton).Enabled = false;
            thongtinchiso.Visible = true;
            LoadProductDataAdmin(hd.MA_HOP_DONG, thongtinchiso);
        }

        public void LoadProductDataAdmin(string MADH, Siticone.Desktop.UI.WinForms.SiticoneGradientPanel main)
        {
            ContractService Contract = new ContractService();
            (main.Controls["txtMaCSQLHD"] as Siticone.Desktop.UI.WinForms.SiticoneTextBox).Text = "";
            (main.Controls["txtTenCS"] as Siticone.Desktop.UI.WinForms.SiticoneTextBox).Text = "";
            (main.Controls["txtGhiChuQLHD"] as Siticone.Desktop.UI.WinForms.SiticoneTextBox).Text = "";
            System.Windows.Forms.GroupBox dulieu = main.Controls["grpDulieuTS"] as System.Windows.Forms.GroupBox;
            System.Windows.Forms.ListView lvDulieuTS = dulieu.Controls["lvDulieuTS"] as System.Windows.Forms.ListView;
            lvDulieuTS.View = View.Details;
            lvDulieuTS.Columns.Clear();
            lvDulieuTS.Columns.Add("Mã chỉ số", 150);
            lvDulieuTS.Columns.Add("Mã nhân viên", 100);
            lvDulieuTS.Columns.Add("Chỉ số", 100);
            lvDulieuTS.Columns.Add("Ngày nhập", 100);
            lvDulieuTS.Columns.Add("Ghi chú", 100);
            lvDulieuTS.Columns.Add("Kết luận SVTC", 150);
            lvDulieuTS.Columns.Add("Kết luận LT", 150);
            lvDulieuTS.Items.Clear();
            using (var context = new CTQLMTContext())
            {
                List<ChiTietChiSo> danhSachChiSo = context.ChiTietChiSos.ToList();
                foreach (var chiso in danhSachChiSo)
                {
                    if(chiso.MA_HOP_DONG == MADH) 
                {
                    var item = new System.Windows.Forms.ListViewItem(chiso.MA_CHI_SO);
                    item.SubItems.Add(chiso.MA_NHAN_VIEN);
                    item.SubItems.Add(chiso.CHI_SO.ToString());
                    item.SubItems.Add(chiso.NGAY_NHAP.ToString("dd/MM/yyyy"));
                    item.SubItems.Add(chiso.GHI_CHU);
                    item.SubItems.Add(chiso.KET_LUAN_SV_TC);
                    item.SubItems.Add(chiso.KET_LUAN_LT);
                    lvDulieuTS.Items.Add(item);
                }
            }
            }
        }

        public List<ChiSoMoiTruongDTO> GetDanhSachChiSo(string MAHD)
        {
            List<ChiSoMoiTruongDTO> danhSachChiSo;
            using (var context = new CTQLMTContext())
            {
                danhSachChiSo = (from hd in context.HopDongs
                                     join ctcs in context.ChiTietChiSos on hd.MA_HOP_DONG equals ctcs.MA_HOP_DONG
                                     join csmt in context.ChiSoMoiTruongs on ctcs.MA_CHI_SO equals csmt.MA_CHI_SO
                                     join nv in context.NhanViens on ctcs.MA_NHAN_VIEN equals nv.MA_NHAN_VIEN
                                     where hd.MA_HOP_DONG == MAHD
                                     select new ChiSoMoiTruongDTO
                                     {
                                         MA_CHI_SO = csmt.MA_CHI_SO,
                                         TEN_CHI_SO = csmt.TEN_CHI_SO,
                                         HO_TEN = nv.HO_TEN,
                                         LOAI_MOI_TRUONG = csmt.LOAI_MOI_TRUONG,
                                         CHI_SO = ctcs.CHI_SO,
                                         TIEU_CHUAN = csmt.TIEU_CHUAN,
                                         VI_TRI = csmt.VI_TRI,
                                         NGAY_NHAP = ctcs.NGAY_NHAP,
                                         GHI_CHU = ctcs.GHI_CHU,
                                         KET_LUAN_SV_TC = ctcs.KET_LUAN_SV_TC,
                                         KET_LUAN_LT = ctcs.KET_LUAN_LT
                                     }).ToList();
            }
            return danhSachChiSo;
        }
        public List<ChiSoMoiTruongDTOR> GetDanhSachChiSoReport(string MAHD)
        {
            List<ChiSoMoiTruongDTOR> danhSachChiSo;
            using (var context = new CTQLMTContext())
            {
                danhSachChiSo = (from hd in context.HopDongs
                                 join ctcs in context.ChiTietChiSos on hd.MA_HOP_DONG equals ctcs.MA_HOP_DONG
                                 join csmt in context.ChiSoMoiTruongs on ctcs.MA_CHI_SO equals csmt.MA_CHI_SO
                                 join nv in context.NhanViens on ctcs.MA_NHAN_VIEN equals nv.MA_NHAN_VIEN
                                 where hd.MA_HOP_DONG == MAHD
                                 select new ChiSoMoiTruongDTOR
                                 {
                                     MA_CHI_SO = csmt.MA_CHI_SO,
                                     TEN_CHI_SO = csmt.TEN_CHI_SO,
                                     HO_TEN = nv.HO_TEN,
                                     LOAI_MOI_TRUONG = csmt.LOAI_MOI_TRUONG,
                                     CHI_SO = ctcs.CHI_SO,
                                     TIEU_CHUAN = csmt.TIEU_CHUAN,
                                     VI_TRI = csmt.VI_TRI,
                                     NGAY_NHAP = ctcs.NGAY_NHAP,
                                     GHI_CHU = ctcs.GHI_CHU,
                                     KET_LUAN_SV_TC = ctcs.KET_LUAN_SV_TC,
                                     KET_LUAN_LT = ctcs.KET_LUAN_LT
                                 }).ToList();
            }
            return danhSachChiSo;
        }

        public void LoadProductData(string MADH, System.Windows.Forms.SplitContainer main)
        {
            System.Windows.Forms.GroupBox thongtin = main.Panel2.Controls["grbThongtinDH"] as System.Windows.Forms.GroupBox;
            System.Windows.Forms.GroupBox chucnang = main.Panel2.Controls["grbChucnang"] as System.Windows.Forms.GroupBox;
            System.Windows.Forms.GroupBox dulieu = main.Panel2.Controls["grpDulieuDH"] as System.Windows.Forms.GroupBox;
            ContractService Contract = new ContractService();
            (thongtin.Controls["txtTenthongso"] as Siticone.Desktop.UI.WinForms.SiticoneTextBox).Text = "";
            (thongtin.Controls["txtKetqua"] as Siticone.Desktop.UI.WinForms.SiticoneTextBox).Text = "";
            (thongtin.Controls["txtGhichu"] as Siticone.Desktop.UI.WinForms.SiticoneTextBox).Text = ""; ;
            System.Windows.Forms.ListView lvDulieuTS = dulieu.Controls["lvDulieudonhang"] as System.Windows.Forms.ListView; 
            lvDulieuTS.View = View.Details;
            lvDulieuTS.Columns.Clear();
            lvDulieuTS.Columns.Add("Tên chỉ số", 150);
            lvDulieuTS.Columns.Add("Loại môi trường", 100);
            lvDulieuTS.Columns.Add("Chỉ số", 100);
            lvDulieuTS.Columns.Add("Tiêu chuẩn", 100);
            lvDulieuTS.Columns.Add("Vị trí", 100);
            lvDulieuTS.Columns.Add("Ngày nhập", 150);
            lvDulieuTS.Columns.Add("Ghi chú", 150);
            lvDulieuTS.Columns.Add("Kết luận SVTC", 150);
            lvDulieuTS.Columns.Add("Kết luận LT", 150);
            lvDulieuTS.Columns.Add("Mã thông số", 0);
            lvDulieuTS.Items.Clear();
            List<ChiSoMoiTruongDTO> danhSachChiSo = Contract.GetDanhSachChiSo(MADH);
            foreach (var chiso in danhSachChiSo)
            {
                var item = new System.Windows.Forms.ListViewItem(chiso.TEN_CHI_SO);
                item.SubItems.Add(chiso.LOAI_MOI_TRUONG);
                item.SubItems.Add(chiso.CHI_SO.ToString());
                item.SubItems.Add(chiso.TIEU_CHUAN);
                item.SubItems.Add(chiso.VI_TRI);
                item.SubItems.Add(chiso.NGAY_NHAP.ToString("dd/MM/yyyy"));
                item.SubItems.Add(chiso.GHI_CHU);
                item.SubItems.Add(chiso.KET_LUAN_SV_TC);
                item.SubItems.Add(chiso.KET_LUAN_LT);
                item.SubItems.Add(chiso.MA_CHI_SO);
                lvDulieuTS.Items.Add(item);
            }
        }

        //them moi dsach hop dong tu database
        public void ShowContractsSearch(List<HopDong> hopDongs, DuAnCNPM.Views.DoubleBufferedPanel container, System.Windows.Forms.SplitContainer chitiet)
        {
            container.Controls.Clear();

            int yOffset = 5;
                foreach (var hd in hopDongs)
                {
                    if (hd.TRANG_THAI == true)
                    {
                        var grbox = new SiticoneGroupBox();
                        var txtNgayHetHan = new SiticoneTextBox();
                        var txtTieuDe = new SiticoneTextBox();
                        container.Controls.Add(grbox);
                        grbox.Controls.Add(txtNgayHetHan);
                        grbox.Controls.Add(txtTieuDe);
                        grbox.BorderColor = System.Drawing.Color.LightGray;
                        grbox.BorderRadius = 18;
                        grbox.BorderThickness = 2;
                        grbox.CustomBorderColor = System.Drawing.Color.AliceBlue;
                        grbox.CustomBorderThickness = new System.Windows.Forms.Padding(0);
                        grbox.FillColor = System.Drawing.Color.Gainsboro;
                        grbox.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
                        grbox.ForeColor = System.Drawing.Color.Black;
                        grbox.Location = new System.Drawing.Point(5, yOffset);
                        grbox.Name = hd.MA_HOP_DONG;
                        grbox.Visible = true;
                        grbox.Size = new System.Drawing.Size(container.Width - 20, 53);
                        grbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                        int width = grbox.Width - 20;

                        txtNgayHetHan.BackColor = System.Drawing.Color.Gainsboro;
                        txtNgayHetHan.BorderColor = System.Drawing.Color.Empty;
                        txtNgayHetHan.BorderThickness = 0;
                        txtNgayHetHan.DefaultText = "Ngày hết hạn: " + hd.NGAY_TRA_KQ;
                        txtNgayHetHan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
                        txtNgayHetHan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
                        txtNgayHetHan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
                        txtNgayHetHan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
                        txtNgayHetHan.FillColor = System.Drawing.Color.Gainsboro;
                        txtNgayHetHan.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
                        txtNgayHetHan.ForeColor = System.Drawing.Color.Black;
                        txtNgayHetHan.Location = new System.Drawing.Point(11, 28);
                        txtNgayHetHan.Name = "txtNgayhethan-" + hd.MA_CONG_TY + "-" + hd.MA_NHAN_VIEN;
                        txtNgayHetHan.ReadOnly = true;
                        txtNgayHetHan.Visible = true;
                        txtNgayHetHan.Size = new System.Drawing.Size(width, 18);
                        txtNgayHetHan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

                        txtTieuDe.BackColor = System.Drawing.Color.Gainsboro;
                        txtTieuDe.BorderColor = System.Drawing.Color.Empty;
                        txtTieuDe.BorderThickness = 0;
                        txtTieuDe.DefaultText = hd.MA_HOP_DONG + "-" + hd.MA_CONG_TY;
                        txtTieuDe.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
                        txtTieuDe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
                        txtTieuDe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
                        txtTieuDe.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
                        txtTieuDe.FillColor = System.Drawing.Color.Gainsboro;
                        txtTieuDe.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
                        txtTieuDe.ForeColor = System.Drawing.Color.Black;
                        txtTieuDe.Location = new System.Drawing.Point(11, 6);
                        txtTieuDe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                        txtTieuDe.Name = hd.MA_HOP_DONG;
                        txtTieuDe.ReadOnly = true;
                        txtTieuDe.Visible = true;
                        txtTieuDe.Size = new System.Drawing.Size(width, 18);
                        txtTieuDe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                        yOffset += grbox.Height + 5;

                        grbox.Click += (s, e) => ShowContractDetail(hd, chitiet);
                        txtTieuDe.Click += (s, e) => ShowContractDetail(hd, chitiet);
                        txtNgayHetHan.Click += (s, e) => ShowContractDetail(hd, chitiet);

                        container.MouseEnter += (s, e) =>
                        {
                            container.FillColor = Color.DarkGray;
                            container.BorderColor = Color.DeepSkyBlue;

                            txtTieuDe.FillColor = Color.DarkGray;
                            txtNgayHetHan.FillColor = Color.DarkGray;
                        };

                        container.MouseLeave += (s, e) =>
                        {
                            container.FillColor = Color.Gainsboro;
                            container.BorderColor = Color.LightGray;

                            txtTieuDe.FillColor = Color.Gainsboro;
                            txtNgayHetHan.FillColor = Color.Gainsboro;

                        };
                    }
                }
        }

        //them moi dsach hop dong tu database của nhân viên
        public void ShowContracts(DuAnCNPM.Views.DoubleBufferedPanel container, System.Windows.Forms.SplitContainer chitiet)
        {
            container.Controls.Clear();

            int yOffset = 5;
            using (var context = new CTQLMTContext())
            {
                var danhsach = context.HopDongs.ToList();
                foreach (var hd in danhsach)
                {
                    if (hd.TRANG_THAI == true)
                    {
                        var grbox = new SiticoneGroupBox();
                        var txtNgayHetHan = new SiticoneTextBox();
                        var txtTieuDe = new SiticoneTextBox();
                        container.Controls.Add(grbox);
                        grbox.Controls.Add(txtNgayHetHan);
                        grbox.Controls.Add(txtTieuDe);
                        grbox.BorderColor = System.Drawing.Color.LightGray;
                        grbox.BorderRadius = 18;
                        grbox.BorderThickness = 2;
                        grbox.CustomBorderColor = System.Drawing.Color.AliceBlue;
                        grbox.CustomBorderThickness = new System.Windows.Forms.Padding(0);
                        grbox.FillColor = System.Drawing.Color.Gainsboro;
                        grbox.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
                        grbox.ForeColor = System.Drawing.Color.Black;
                        grbox.Location = new System.Drawing.Point(5, yOffset);
                        grbox.Name = hd.MA_HOP_DONG;
                        grbox.Visible = true;
                        grbox.Size = new System.Drawing.Size(container.Width - 20, 53);
                        grbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

                        int width = grbox.Width - 20;
                        txtNgayHetHan.BackColor = System.Drawing.Color.Gainsboro;
                        txtNgayHetHan.BorderColor = System.Drawing.Color.Empty;
                        txtNgayHetHan.BorderThickness = 0;
                        txtNgayHetHan.DefaultText = "Ngày hết hạn: " + hd.NGAY_TRA_KQ;
                        txtNgayHetHan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
                        txtNgayHetHan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
                        txtNgayHetHan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
                        txtNgayHetHan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
                        txtNgayHetHan.FillColor = System.Drawing.Color.Gainsboro;
                        txtNgayHetHan.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
                        txtNgayHetHan.ForeColor = System.Drawing.Color.Black;
                        txtNgayHetHan.Location = new System.Drawing.Point(11, 28);
                        txtNgayHetHan.Name = "txtNgayhethan-" + hd.MA_CONG_TY + "-" + hd.MA_NHAN_VIEN;
                        txtNgayHetHan.ReadOnly = true;
                        txtNgayHetHan.Visible = true;
                        txtNgayHetHan.Size = new System.Drawing.Size(width, 18);
                        txtNgayHetHan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

                        txtTieuDe.BackColor = System.Drawing.Color.Gainsboro;
                        txtTieuDe.BorderColor = System.Drawing.Color.Empty;
                        txtTieuDe.BorderThickness = 0;
                        txtTieuDe.DefaultText = hd.MA_HOP_DONG + "-" + hd.MA_CONG_TY;
                        txtTieuDe.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
                        txtTieuDe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
                        txtTieuDe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
                        txtTieuDe.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
                        txtTieuDe.FillColor = System.Drawing.Color.Gainsboro;
                        txtTieuDe.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
                        txtTieuDe.ForeColor = System.Drawing.Color.Black;
                        txtTieuDe.Location = new System.Drawing.Point(11, 6);
                        txtTieuDe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                        txtTieuDe.Name = hd.MA_HOP_DONG;
                        txtTieuDe.ReadOnly = true;
                        txtTieuDe.Visible = true;
                        txtTieuDe.Size = new System.Drawing.Size(width, 18);
                        txtTieuDe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                        yOffset += grbox.Height + 5;

                        grbox.Click += (s, e) => ShowContractDetail(hd, chitiet);
                        txtTieuDe.Click += (s, e) => ShowContractDetail(hd, chitiet);
                        txtNgayHetHan.Click += (s, e) => ShowContractDetail(hd, chitiet);

                        container.MouseEnter += (s, e) =>
                        {
                            container.FillColor = Color.DarkGray;
                            container.BorderColor = Color.DeepSkyBlue;

                            txtTieuDe.FillColor = Color.DarkGray;
                            txtNgayHetHan.FillColor = Color.DarkGray;
                        };

                        container.MouseLeave += (s, e) =>
                        {
                            container.FillColor = Color.Gainsboro;
                            container.BorderColor = Color.LightGray;

                            txtTieuDe.FillColor = Color.Gainsboro;
                            txtNgayHetHan.FillColor = Color.Gainsboro;

                        };
                    }
                }
            }
        }

        private void ShowContractDetail(HopDong hd, System.Windows.Forms.SplitContainer main)
        {
            System.Windows.Forms.GroupBox thongtin = main.Panel2.Controls["grbThongtinDH"] as System.Windows.Forms.GroupBox;
            System.Windows.Forms.GroupBox chucnang = main.Panel2.Controls["grbChucnang"] as System.Windows.Forms.GroupBox;
            System.Windows.Forms.GroupBox dulieu = main.Panel2.Controls["grpDulieuDH"] as System.Windows.Forms.GroupBox;
            (thongtin.Controls["txtMadonhang"] as Siticone.Desktop.UI.WinForms.SiticoneTextBox).Text = hd.MA_HOP_DONG;
            (chucnang.Controls["btnSua"] as Siticone.Desktop.UI.WinForms.SiticoneButton).Enabled = false;
            (chucnang.Controls["btnPrint"] as Siticone.Desktop.UI.WinForms.SiticoneButton).Enabled = true;
            (chucnang.Controls["btnLuu"] as Siticone.Desktop.UI.WinForms.SiticoneButton).Enabled = false;
            LoadProductData(hd.MA_HOP_DONG, main);
            //((((main.Parent.Parent) as System.Windows.Forms.SplitContainer)
            //    .Panel1).Controls["btnBackNV"] as Siticone.Desktop.UI.WinForms.SiticoneButton).Visible = true;
        }

        public HashSet<String> timeData()
        {
            HashSet<String> data = new HashSet<string>();
            using (var context = new CTQLMTContext())
            {
                var listHD = context.HopDongs.ToList();
                foreach (HopDong hd in listHD)
                {
                    data.Add(hd.QUY);
                    data.Add(hd.NGAY_KY.Value.Year.ToString());
                }
            }
            return data;
        }

        public int sumHDYear(String year)
        {
            int nam = int.Parse(year);
            var listData = new List<HopDong>();
            using (var context = new CTQLMTContext())
            {
                var listHD = context.HopDongs.ToList();
                foreach (HopDong hd in listHD)
                {
                    if (hd.NGAY_KY.Value.Year == nam)
                    {
                        listData.Add(hd);
                    }
                }
            }
            return listData.Count();
        }

        public int sumHDQuarter(String quarter)
        {
            List<HopDong> listHDQuy = new List<HopDong>();
            using (var context = new CTQLMTContext())
            {
                var listHD = context.HopDongs.ToList();
                foreach (HopDong hd in listHD)
                {
                    if (hd.QUY == quarter)
                    {
                        listHDQuy.Add(hd);
                    }
                }
            }
            return listHDQuy.Count();
        }

        public Dictionary<String, int> dataForYearChart(String year)
        {
            int nam = int.Parse(year);
            Dictionary<String, int> dicData = new Dictionary<String, int>();
            dicData.Add("1/" + year, 0);
            dicData.Add("2/" + year, 0);
            dicData.Add("3/" + year, 0);
            dicData.Add("4/" + year, 0);

            var listData = new List<HopDong>();
            using (var context = new CTQLMTContext())
            {
                var listHD = context.HopDongs.ToList();
                foreach (HopDong hd in listHD)
                {
                    if (hd.NGAY_KY.Value.Year == nam)
                    {
                        listData.Add(hd);
                    }
                }
            }

            foreach (HopDong hd in listData)
            {
                String temp = hd.QUY;
                if (dicData.ContainsKey(temp))
                {
                    dicData[temp]++;
                }
            }
            return dicData;
        }

        public Dictionary<String, int> dataForQuarter(String quy)
        {
            Dictionary<String, int> dic = new Dictionary<String, int>();
            List<HopDong> listHDQuy = new List<HopDong>();
            using (var context = new CTQLMTContext())
            {
                var listHD = context.HopDongs.ToList();
                foreach (HopDong hd in listHD)
                {
                    if (hd.QUY == quy)
                    {
                        listHDQuy.Add(hd);
                    }
                }
            }

            foreach (HopDong hd in listHDQuy)
            {
                String month = hd.NGAY_KY.Value.Month.ToString();
                if (dic.ContainsKey(month))
                {
                    dic[month]++;
                }
                else
                {
                    dic.Add(month, 1);
                }
            }
            return dic;
        }

        public Boolean checkPrintCondition(String maDonHang)
        {
            var list = new List<ChiTietChiSo>();
            using(var context = new CTQLMTContext())
            {
                var listCTTS = context.ChiTietChiSos.ToList();
                foreach(var ctcs in listCTTS)
                {
                    if (ctcs.MA_HOP_DONG == maDonHang)
                    {
                        list.Add(ctcs);
                    }
                }
            }
            foreach (ChiTietChiSo cs in list)
            {
                if (!cs.FLAG)
                {
                    return false;
                }
            }
            return true;
        }

        public Dictionary<String, int> dataForPieChart(String quarter)
        {
            Dictionary<String, int> dic = new Dictionary<string, int>();
            dic.Add("Hoàn thành", getPerfectContract(quarter));
            dic.Add("Đang xữ lý", getProgressingContract(quarter));
            dic.Add("Trễ", getDelayContract(quarter));

            return dic;
        }

        private int checkTime(String time)
        {
            for (int i = 0; i < time.Length; i++)
            {
                if (time[i] == '/')
                {
                    return 1;    // quy
                }
            }
            return 0;            // nam
        }

        public int getPerfectContract(String time)
        {
            int check = checkTime(time);
            int count = 0;
            if (check == 1)
            {
                using (var context = new CTQLMTContext())
                {
                    var hopDong = context.HopDongs.ToList();
                    foreach(HopDong hd in hopDong)
                    {
                        if (hd.HOAN_THANH == true && hd.QUY == time)
                        {
                            count++;
                        }
                    }
                }
                return count;
            }
            else
            {
                using(var context = new CTQLMTContext())
                {
                    var hopDong = context.HopDongs.ToList();
                    foreach(HopDong hd in hopDong)
                    {
                        if (hd.HOAN_THANH == true && hd.NGAY_KY.Value.Year.ToString() == time)
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }

        public int getProgressingContract(String time)
        {
            int check = checkTime(time);
            int count = 0;
            if (check == 1)
            {
                using (var context = new CTQLMTContext())
                {
                    var hopDong = context.HopDongs.ToList();
                    foreach (HopDong hd in hopDong)
                    {
                        if (hd.HOAN_THANH == false && hd.QUY == time && DateTime.Today <= hd.NGAY_TRA_KQ)
                        {
                            count++;
                        }
                    }
                }
            }
            else
            {
                using (var context = new CTQLMTContext())
                {
                    var hopDong = context.HopDongs.ToList();
                    foreach (HopDong hd in hopDong)
                    {
                        if (hd.HOAN_THANH == false && hd.NGAY_KY.Value.Year.ToString() == time && DateTime.Today <= hd.NGAY_TRA_KQ)
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }

        public int getDelayContract(String time)
        {
            int check = checkTime(time);
            int count = 0;
            if (check == 1)
            {
                using (var context = new CTQLMTContext())
                {
                    var hopDong = context.HopDongs.ToList();
                    foreach (HopDong hd in hopDong)
                    {
                        if (hd.HOAN_THANH == false && hd.QUY == time && DateTime.Today >= hd.NGAY_TRA_KQ)
                        {
                            count++;
                        }
                    }
                }
            }
            else
            {
                using (var context = new CTQLMTContext())
                {
                    var hopDong = context.HopDongs.ToList();
                    foreach (HopDong hd in hopDong)
                    {
                        if (hd.HOAN_THANH == false && hd.NGAY_KY.Value.Year.ToString() == time && DateTime.Today >= hd.NGAY_TRA_KQ)
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }
    }
}
