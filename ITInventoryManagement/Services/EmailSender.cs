using MimeKit;
using System.Net;
using System.Net.Mail;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Identity;

namespace ITInventoryManagement.Services
{

    public class EmailSender : IEmailSender
    {
        private readonly string _smtpServer = "smtp.yourserver.com"; // SMTP server adresiniz
        private readonly int _smtpPort = 587; // SMTP server portu
        private readonly string _smtpUser = "your-email@yourdomain.com"; // SMTP kullanıcı adı
        private readonly string _smtpPass = "your-email-password"; // SMTP şifresi

        public async Task SendEmailAsync(string to, string subject, string message)
        {
            MailMessage mail = new MailMessage();

            mail.From = new MailAddress("sender@example.com");
            mail.To.Add(to);

            mail.Subject = subject;
            mail.Body = message;

            SmtpClient smtpClient = new SmtpClient(_smtpServer);

            smtpClient.Port = 587; 
            smtpClient.Credentials = new NetworkCredential(_smtpUser, _smtpPass);
            smtpClient.EnableSsl = true; 

            smtpClient.Send(mail);
        }
    }
}
