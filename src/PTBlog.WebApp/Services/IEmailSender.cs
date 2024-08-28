using PTBlog.WebApp.Models;

namespace PTBlog.WebApp.Services
{
    public interface IEmailSender
    {
        Task SendEmail(EmailData emailData);
    }
}
