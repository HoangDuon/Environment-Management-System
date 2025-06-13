using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;
using DuAnCNPM.Datas;
using System.Windows;
using System.Windows.Forms;

namespace DuAnCNPM.Controller
{
    class EmailService
    {
        public EmailService() { }

        public bool sentEmailLeader()
        {
            using (var context = new CTQLMTContext())
            {
                List<NhanVien> nhanviens = context.NhanViens
                                                  .Where(nv => (nv.TRANG_THAI == true && nv.CHUC_VU == "PTN" && nv.TRUONG_PHONG == true) || (nv.TRANG_THAI == true && nv.CHUC_VU == "PQT" && nv.TRUONG_PHONG == true))
                                                  .ToList();
                foreach (var nv in nhanviens)
                {
                    string senderEmail = "hd34227@gmail.com";
                    string senderPassword = "sorctpcevisgwwfc";
                    string subject = "THÔNG BÁO THỜI HẠN THỰC HIỆN QUAN TRẮC";
                    string body = $"Gửi trường phòng {nv.HO_TEN},\r\n" +
                        $"Căn cứ theo kế hoặch quan trắc môi trường của hợp đồng đã sắp tới lúc thực hiện quan trắc. " +
                        $"Yêu cầu trưởng phòng nhận được email này phải thông báo khẩn cấp đến nhân viên trong nhóm để có sự sắp xếp ổn thỏa." +
                        $"\r\nNếu có thắc mắc vui lòng liên hệ qua email này.\r\nTrân trọng,\r\nTechHive Company\r\n";
                    try
                    {
                        using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                        {
                            smtp.Credentials = new NetworkCredential(senderEmail, senderPassword);
                            smtp.EnableSsl = true;

                            MailMessage mail = new MailMessage();
                            mail.From = new MailAddress(senderEmail);
                            mail.To.Add(nv.GMAIL);
                            mail.Subject = subject;
                            mail.Body = body;

                            smtp.Send(mail);
                        }
                    }
                    catch (Exception ex)
                    {
                        System.Windows.MessageBox.Show($"Không gửi được mail đến {nv.GMAIL}: {ex.Message}", "Lỗi gửi mail", (MessageBoxButton)MessageBoxButtons.OK, (MessageBoxImage)MessageBoxIcon.Error);
                    }
                }
                return false;
            }
        }

        public bool sentEmailEmployees()
        {
            using (var context = new CTQLMTContext())
            {
                List<NhanVien> nhanviens = context.NhanViens
                                                  .Where(nv => (nv.TRANG_THAI == true && nv.CHUC_VU == "PTN") || (nv.TRANG_THAI == true && nv.CHUC_VU == "PQT"))
                                                  .ToList();
                DateTime today = DateTime.Today;
                DateTime tuNgay = today.AddDays(16);
                DateTime denNgay = today.AddDays(17);

                List<HopDong> hopdongs = context.HopDongs
                    .Where(hd => hd.NGAY_TRA_KQ >= tuNgay && hd.NGAY_TRA_KQ <= denNgay)
                    .ToList();
                foreach (var hd in hopdongs)
                {
                    foreach (var nv in nhanviens)
                    {
                        string senderEmail = "hd34227@gmail.com";
                        string senderPassword = "sorctpcevisgwwfc";
                        string subject = "CẢNH BÁO VỀ ĐƠN HÀNG SẮP ĐẾN HẠN TRẢ KẾT QUẢ";
                        string body = $"Chào {nv.HO_TEN},\r\n\r\n" +
                                      "Hệ thống đã ghi nhận đơn hàng mà nhân viên được phân công, tuy nhiên hiện nay chưa thấy có kết quả được trả về.\r\n" +
                                      $"Yêu cầu nhân viên nhanh chóng thực hiện các công tác quan trắc trước ngày trả kết quả của đơn hàng {hd.MA_HOP_DONG} - {hd.NGAY_TRA_KQ}.\r\n\r\n" +
                                      "Nếu có thắc mắc vui lòng liên hệ qua email này.\r\n\r\n" +
                                      "Trân trọng,\r\n" +
                                      "TechHive Company.";

                        try
                        {
                            using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                            {
                                smtp.Credentials = new NetworkCredential(senderEmail, senderPassword);
                                smtp.EnableSsl = true;

                                MailMessage mail = new MailMessage();
                                mail.From = new MailAddress(senderEmail);
                                mail.To.Add(nv.GMAIL);
                                mail.Subject = subject;
                                mail.Body = body;

                                smtp.Send(mail);
                            }
                        }
                        catch (Exception ex)
                        {
                            System.Windows.MessageBox.Show($"Không gửi được mail đến {nv.GMAIL}: {ex.Message}", "Lỗi gửi mail", (MessageBoxButton)MessageBoxButtons.OK, (MessageBoxImage)MessageBoxIcon.Error);
                        }
                    }
                }
                return false;
            }
        }

        public bool sentEmailCustomers()
        {
            using (var context = new CTQLMTContext())
            {
                DateTime today = DateTime.Today;
                DateTime ngayCanhBao = today.AddDays(-1);
                List<HopDong> hopdongs = context.HopDongs
                    .Where(hd => hd.NGAY_TRA_KQ >= today && hd.NGAY_TRA_KQ <= ngayCanhBao)
                    .ToList();
                foreach (var hd in hopdongs) {
                    KhachHang khachhhang = context.KhachHangs.ToList().FirstOrDefault(kh => kh.MA_CONG_TY==hd.MA_CONG_TY);

                        string senderEmail = "hd34227@gmail.com";
                        string senderPassword = "sorctpcevisgwwfc";
                        string subject = "THÔNG BÁO VỀ VIỆC TÁI KÍ HỢP ĐỒNG";
                        string body = $"Kính gửi {khachhhang.TEN_CONG_TY},\r\n\r\n" +
                                  "Cảm ơn phía khách hàng đã sử dụng dịch vụ quan trắc ở phía công ty trong thời gian qua.\r\n" +
                                  "Hiện nay sau thời gian nhất định, môi trường mà quý khách muốn thực hiện quan trắc ở quý trước chắc đã có những thay đổi.\r\n" +
                                  "Nếu có nhu cầu tái ký hợp đồng mới, quý khách vui lòng liên hệ lại với phía công ty.\r\n\r\n" +
                                  "Nếu có thắc mắc vui lòng liên hệ qua email này.\r\n\r\n" +
                                  "Trân trọng,\r\n" +
                                  "TechHive Company.";

                    try
                    {
                            using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                            {
                                smtp.Credentials = new NetworkCredential(senderEmail, senderPassword);
                                smtp.EnableSsl = true;

                                MailMessage mail = new MailMessage();
                                mail.From = new MailAddress(senderEmail);
                                mail.To.Add(khachhhang.GMAIL_KHACHHANG);
                                mail.Subject = subject;
                                mail.Body = body;

                                smtp.Send(mail);
                            }
                        }
                        catch (Exception ex)
                        {
                            System.Windows.MessageBox.Show($"Không gửi được mail đến {khachhhang.GMAIL_KHACHHANG}: {ex.Message}", "Lỗi gửi mail", (MessageBoxButton)MessageBoxButtons.OK, (MessageBoxImage)MessageBoxIcon.Error);
                        }
                }
                return false;
            }
        }

    }
}
