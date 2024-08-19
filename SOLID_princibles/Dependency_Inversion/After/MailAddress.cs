using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion.After
{
    internal class MailAddress : IMessageDelivery
    {
        public string Address { get; set; }
        public void Send()
        {
            Console.WriteLine($"Mail is sent to {Address}");
        }
    }
}
