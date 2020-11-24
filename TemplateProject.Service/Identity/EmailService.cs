using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;

namespace TemplateProject.Service.Identity
{
    public class EmailService : IIdentityMessageService
    {
        public Task SendAsync(IdentityMessage message)
        {
            var client = new SmtpClient();
             
           
            return client.SendMailAsync(new MailMessage
            {
                To = { message.Destination },
                Subject = message.Subject,
                Body = message.Body,
                IsBodyHtml = true
            }); 
        }
    }
}
