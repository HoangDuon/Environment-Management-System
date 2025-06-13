using DuAnCNPM.Datas;
using System;
using System.Linq;
using BCrypt.Net;
namespace DuAnCNPM.Controller
{
    class SignInService
    {
        public SignInService()
        {
        }

        public bool signInService(String Name, String Password)
        {
            using (var db = new CTQLMTContext())
            {
                var nhanVien = db.NhanViens.FirstOrDefault(tk => tk.MA_NHAN_VIEN == Name);
                if (nhanVien != null && BCrypt.Net.BCrypt.Verify(Password, nhanVien.MAT_KHAU))
                {
                    UserInform.manhanvien = nhanVien.MA_NHAN_VIEN;
                    UserInform.name = nhanVien.HO_TEN;
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public string getName(String Name, String Password)
        {
            if (signInService(Name, Password)){
                using (var db = new CTQLMTContext())
                {
                    String pass = BCrypt.Net.BCrypt.HashPassword(Password);
                    var nhanVien = db.NhanViens.FirstOrDefault(tk => tk.MA_NHAN_VIEN == Name);
                    if (nhanVien != null && BCrypt.Net.BCrypt.Verify(Password, nhanVien.MAT_KHAU))
                    {
                        return nhanVien.HO_TEN;
                    }
                    return "";
                }
            }
            else
            {
                return "";
            }
        }

        public string getRole(String Name, String Password)
        {
            if (signInService(Name, Password))
            {
                using (var db = new CTQLMTContext())
                {
                    String pass = BCrypt.Net.BCrypt.HashPassword(Password);
                    var nhanVien = db.NhanViens.FirstOrDefault(tk => tk.MA_NHAN_VIEN == Name);
                    if (nhanVien != null && BCrypt.Net.BCrypt.Verify(Password, nhanVien.MAT_KHAU))
                    {
                        return nhanVien.CHUC_VU;
                    }
                    return "";
                }
            }
            else
            {
                return "";
            }
        }

        public string getID(String Name, String Password)
        {
            if (signInService(Name, Password))
            {
                using (var db = new CTQLMTContext())
                {
                    var nhanVien = db.NhanViens.FirstOrDefault(tk => tk.MA_NHAN_VIEN == Name);
                    if (nhanVien != null && BCrypt.Net.BCrypt.Verify(Password, nhanVien.MAT_KHAU))
                    {
                        return nhanVien.MA_NHAN_VIEN;
                    }
                    return "";
                }
            }
            else
            {
                return "";
            }
        }
    }
}