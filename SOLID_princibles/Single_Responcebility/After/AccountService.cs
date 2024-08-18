using SOLID.SRP.Before;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility.After
{
    internal class AccountService
    {
        public void Withdraw(decimal amount, Account account)
        {
            var transactionMessage = "";

            // handle withdraw
            if (amount > 0)
            {
                if (account.Balance < Math.Abs(amount))
                {
                    transactionMessage =
                    $"OVERDRAFT when trying to withdraw " +
                    $"{Math.Abs(amount).ToString("C2")}," +
                    $" current balance {account.Balance.ToString("C2")}";
                }
                else
                {
                    account.Balance -= amount;
                    transactionMessage =
                       $"OK Withdraw {Math.Abs(amount).ToString("C2")}" +
                       $", current balance {account.Balance.ToString("C2")}";
                }
                EmailService emailService = new EmailService();
                emailService.Send(account, transactionMessage);
            }
        }
        public void Deposite(decimal amount, Account account)
        {
            var transactionMessage = "";
            if (amount > 0)
            {
                account.Balance += amount;

                transactionMessage =
                    $"OK Deposit {amount.ToString("C2")}" +
                    $", current balance {account.Balance.ToString("C2")}";
            }
            EmailService emailService = new EmailService();
            emailService.Send(account, transactionMessage);
        }
    }
}
