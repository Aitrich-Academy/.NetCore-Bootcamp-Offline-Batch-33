namespace API_Auth.Interface
{
    public interface IEmailService
    {
        public Task SendEmailAsync(string toEmail,string subject, string body);
    }
}
