using Interface_Segregation.After;
using System.Diagnostics.Metrics;

namespace Interface_Segregation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employees = Repository.LoadEmployees();

            foreach (var e in employees)
            {
                Console.WriteLine(e.PrintSalarySlip());
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
