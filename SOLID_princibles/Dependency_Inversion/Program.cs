using Dependency_Inversion.After;
using SOLID.DIP.Before;

namespace Dependency_Inversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in Repository.Customers)
            {
                var notification = new After.NotificationService();
                notification.messageDeliveries = new List<After.IMessageDelivery>
                {
                    new After.SMSService{MobileNo = item.MobileNo},
                    new After.MailAddress{Address = item.Address},
                    new After.EmailService{EmailAddress = item.EmailAddress}
                };
                notification.Notify();
            }
        }
    }
}
