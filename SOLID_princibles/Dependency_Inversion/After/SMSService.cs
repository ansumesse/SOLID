using System;
namespace Dependency_Inversion.After
{

    internal class SMSService : IMessageDelivery
    {
        public string MobileNo { get; set; } 

        public void Send()
        {
            Console.WriteLine($"SMS is sent to {MobileNo}");
        }
    }
}
