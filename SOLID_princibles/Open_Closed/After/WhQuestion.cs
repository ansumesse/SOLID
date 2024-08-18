using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed.After
{
    internal class WhQuestion : Question
    {
        public override void PrintQustion()
        {
            Console.WriteLine($"{Title} [{Mark}]");

            Console.WriteLine("  _____________________________");
            Console.WriteLine("  _____________________________");
            Console.WriteLine("  _____________________________");
        }
    }
}
