using AGS.StockControl.Domain.Services;

namespace AGS.StockControl.Tests.Mocks
{
    public class FakeEmailService : IEmailService
    {
        public void Send(string to, string email, string subject, string body)
        {
            
        }
    }
}
