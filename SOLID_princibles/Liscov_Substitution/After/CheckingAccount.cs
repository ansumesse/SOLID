using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liscov_Substitution.After
{
    internal class CheckingAccount : Account, IDeposit, IWithdraw
    {
        public CheckingAccount(string name, decimal balance) :base(name, balance)
        {
            
        }
        public void Deposit(decimal amount)
        {
            Balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            if (amount > 1000)
            {
                Console.WriteLine("You can't withdraw more than $1000");
                return;
            }
            Balance -= amount;
        }
    }
}
