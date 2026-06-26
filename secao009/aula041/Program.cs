using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula041
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sbyte num1, num2, maior;

            Console.Write("#1 valor (0 - 10): ");
            num1 = sbyte.Parse(Console.ReadLine());

            Console.Write("#2 valor (0 - 10): ");
            num2 = sbyte.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                maior = num1;
            } else
            {
                maior = num2;
            }

            Console.WriteLine("O maior valor e " + maior);
            Console.ReadKey();
        }
    }
}
