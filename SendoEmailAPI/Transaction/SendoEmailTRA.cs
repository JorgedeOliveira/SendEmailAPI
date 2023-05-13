using IdentityServer4.Models;
using SendoEmailAPI.Json;
using System.Net;
using System.Net.Mail;

namespace SendoEmailAPI.Transaction
{
    public class SendoEmailTRA
    {
        public static bool SendEmail(EmailDTO emailDTO, bool ishtml = false)
        {
            int portNumber = 587;
            string smtpAdrress = "smtp.gmail.com";

            try
            {
                using (MailMessage mailMessage = new MailMessage())
                {
                    mailMessage.From = new MailAddress(emailDTO.FromEmail);

                    mailMessage.Subject = emailDTO.Subject;
                    mailMessage.Body = emailDTO.Body;
                    mailMessage.IsBodyHtml = ishtml;
                    mailMessage.To.Add(emailDTO.ToEmail);
                    using (SmtpClient smtp = new SmtpClient(smtpAdrress, portNumber))
                    {
                        smtp.EnableSsl = true;
                        smtp.UseDefaultCredentials = false;
                        smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                        smtp.Credentials = new NetworkCredential(emailDTO.FromEmail, emailDTO.Pwd);
                        smtp.Send(mailMessage);
                    }
                }

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
};








