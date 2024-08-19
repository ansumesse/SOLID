using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liscov_Substitution.After
{
    internal class SavingAccount : Account, IWithdraw, IDeposit
    {
        public SavingAccount(string name, decimal balance) : base(name, balance)
        {
            
        }

        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }
    }
}
