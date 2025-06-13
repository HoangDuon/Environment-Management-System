using DuAnCNPM.Datas;
using System;
using System.Linq;

namespace DuAnCNPM.Controller
{
    class ResetPasswordService
    {
        public ResetPasswordService()
        {

        }

        public bool ResetPasswordServices(String Email, String Password)
        {
            using (var db = new CTQLMTContext())
            {
                var nhanVien = db.NhanViens.FirstOrDefault(tk => tk.GMAIL == Email);
                if (nhanVien != null)
                {
                    nhanVien.MAT_KHAU = BCrypt.Net.BCrypt.HashPassword(Password);
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool ResetPasswordServicesInner(String ID, String Password)
        {
            using (var db = new CTQLMTContext())
            {
                var nhanVien = db.NhanViens.FirstOrDefault(tk => tk.MA_NHAN_VIEN == ID);
                if (nhanVien != null)
                {
                    nhanVien.MAT_KHAU = BCrypt.Net.BCrypt.HashPassword(Password);
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}