using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 1;
            string nome = "Tobias";

            num1 += 14;
            Console.Write("1 + 14 = ");
            Console.WriteLine(num1);

            num1 -= 5;
            Console.Write("15 - 5 = ");
            Console.WriteLine(num1);

            num1 *= 4;
            Console.Write("10 * 4 = ");
            Console.WriteLine(num1);

            num1 /= 2;
            Console.Write("40 / 2 = ");
            Console.WriteLine(num1);

            num1 %= 3;
            Console.Write("20 % 3 = ");
            Console.WriteLine(num1);

            nome += " de Oliveira";

            Console.WriteLine(num1);
            Console.WriteLine(nome);
        }
    }
}
