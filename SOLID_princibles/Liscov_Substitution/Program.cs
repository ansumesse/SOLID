using Liscov_Substitution.After;

namespace Liscov_Substitution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Liskov Substitution: every parent class can replaced by its children
            Account account = new Account("ahmed", 30000);
            Account account2 = new SavingAccount("ahmed", 30000);
            Account account3 = new FixedDepsitAccount("ahmed", 30000);
            Account account4 = new CheckingAccount("ahmed", 30000);
            

        }
    }
}
