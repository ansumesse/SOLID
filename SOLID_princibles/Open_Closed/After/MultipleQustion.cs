using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed.After
{
    internal class MultipleQustion : Question
    {
        public List<string> Choices { get; set; } = new List<string>();
        public override void PrintQustion()
        {
            Console.WriteLine($"{Title} [{Mark}]");
            foreach (var choice in Choices)
            {
                Console.WriteLine($"  {choice}");
            }
        }
    }
}
