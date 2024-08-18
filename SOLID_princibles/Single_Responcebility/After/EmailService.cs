using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Single_Responsibility.After
{
    internal class EmailService
    {
        public void Send(Account account, string transactionMessage)
        {
            Console.WriteLine(
            $"\n\n\t\t To: {account.Email}" +
            $"\n\t\t Subject: Fake Bank Account Activity" +
            $"\n\n\t\t Dear {account.Name}," +
            $"\n\n\t\t\t A recent activity on your account occures at {DateTime.Now.ToString("yyyy-MM-dd hh:mm")}" +
            "\n\t\t\t\t ===> {0}" +
            $"\n\n\t\t Thank You,\n\t\t Fake Bank." +
            $"\n\n\t\t--------------------------- ", transactionMessage);
        }
    }
}
