using Single_Responsibility.After;

namespace Single_Responsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account("Mohamed", "mohamed@gamil.com", 30000);
            AccountService accountService = new AccountService();
            accountService.Withdraw(5000, account);
            accountService.Deposite(5000, account);

        }
    }
}
