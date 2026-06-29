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
            int fib = 0;
            int a = 0, b = 1;

            Console.WriteLine("=> SEQUÊNCIA FIBONACCI <=");
            Console.WriteLine("\nQuantos valor quer que eu mostre? ");
            Console.Write("> ");
            qtd = short.Parse(Console.ReadLine());

            for (int i = 1; i <= qtd; i++)
            {
                Console.WriteLine(fib);
                a = b;
                b = fib; // No primeiro loop, fib = 0.
                fib = a + b;
            }

            Console.ReadKey();
        }
    }
}
