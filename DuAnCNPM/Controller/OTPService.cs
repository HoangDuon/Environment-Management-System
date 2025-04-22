using System;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace DuAnCNPM.Controlers
{
    public class OTPService
    {
        private frmEcoOrder mainForm;
        public OTPService() { }
        public string email = "";
        public OTPService(frmEcoOrder form)
        {
            mainForm = form;
        }
        private string OTP;
        private string generateOTP()
        {
            Random random = new Random();
            string otp = "";
            for (int i = 0; i < 6; i++)
            {
                otp += random.Next(0, 10);
            }
            return otp;
        }
        ///send OTP
        public bool sentOTP(string Gmail)
        {
            OTP = generateOTP();
            string senderEmail = "hd34227@gmail.com";
            string senderPassword = "sorctpcevisgwwfc";
            string subject = "Mã OTP của bạn";
            string body = $"Mã OTP của bạn là: {OTP}";
            email = Gmail;
            try
            {
                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.Credentials = new NetworkCredential(senderEmail, senderPassword);
                    smtp.EnableSsl = true;

                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress(senderEmail);
                    mail.To.Add(Gmail);
                    mail.Subject = subject;
                    mail.Body = body;

                    smtp.Send(mail);
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        ///checking OTP
        public bool OTPChecking(String otp)
        {
            if (OTP.ToString().Equals(otp))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}