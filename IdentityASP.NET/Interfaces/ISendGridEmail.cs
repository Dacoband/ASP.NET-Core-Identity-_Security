namespace IdentityASPNet.Interfaces
{
    public class ISendGridEmail
    {
        Task SendEmailAsync(string toEmail, string subject, string message);
    }
}
