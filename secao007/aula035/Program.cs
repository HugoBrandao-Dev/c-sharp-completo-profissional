using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula035
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 23;
            int b = 21;
            int x = 67;
            int y = 45;

            Console.Write("(23 > 21) && (67 == 45): ");
            Console.WriteLine((a > b) && (x == y));

            Console.Write("(23 > 21) || (67 == 45): ");
            Console.WriteLine((a > b) || (x == y));
        }
    }
}
