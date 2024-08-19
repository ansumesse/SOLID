using System;
namespace Dependency_Inversion.After
{
    internal class EmailService : IMessageDelivery
    {
        public string EmailAddress { get; set; }
         

        public void Send()
        {
            Console.WriteLine($"e-mail is sent to {EmailAddress}");
        }
    }
}
