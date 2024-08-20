using MimeKit;
using System.Net;
using System.Net.Mail;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using ITInventoryManagement.ViewModel;

namespace ITInventoryManagement.Services
{

    public class EmailSender : IEmailSender
    {
        private readonly SmtpSettings _smtpSettings;

        public EmailSender(IOptions<SmtpSettings> smtpSettings)
        {
            _smtpSettings = smtpSettings.Value;
        }

        public async Task SendEmailAsync(string to, string subject, string message)
        {
            MailMessage mail = new MailMessage
            {
                From = new MailAddress(_smtpSettings.User),
                Subject = subject,
                Body = message
            };

            mail.To.Add(to);

            using (SmtpClient smtpClient = new SmtpClient(_smtpSettings.Server, _smtpSettings.Port))
            {
                smtpClient.Credentials = new NetworkCredential(_smtpSettings.User, _smtpSettings.Password);
                smtpClient.EnableSsl = true;

                await smtpClient.SendMailAsync(mail);
            }
        }
    }
}
