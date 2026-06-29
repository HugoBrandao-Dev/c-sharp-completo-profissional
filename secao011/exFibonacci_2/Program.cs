using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exFibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short qtd;

            Console.WriteLine("=> SEQUÊNCIA FIBONACCI <=");
            Console.WriteLine("\nQuantos valores quer que eu mostre? ");
            Console.Write("> ");
            qtd = short.Parse(Console.ReadLine()); 

            for (int i = 1, a = 0, b = 1, fib = 0; i <= qtd; i++, a = b, b = fib, fib = a + b)
            {
                Console.Write(fib + " ");
            }

            Console.ReadKey();
        }
    }
}
