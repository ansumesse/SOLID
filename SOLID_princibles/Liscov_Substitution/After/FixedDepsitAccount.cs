using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liscov_Substitution.After
{
    internal class FixedDepsitAccount: Account, IDeposit
    {
        public FixedDepsitAccount(string name, decimal balance) : base(name, balance)
        {
            
        }
        public void Deposit(decimal amount)
        {
            Balance += amount;
        }
    }
}
