using System.Threading.Tasks;

namespace IdentityASPNet.Interfaces
{
    public interface ISendGridEmail
    {
        Task SendEmailAsync(string toEmail, string subject, string message);
    }
}
