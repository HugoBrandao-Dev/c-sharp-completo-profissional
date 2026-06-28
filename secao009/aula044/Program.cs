using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula044
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sbyte num;
            string msg = "\n";

            Console.Write("Informe um valor (0 - 10): ");
            num = sbyte.Parse(Console.ReadLine());

            msg += num % 2 == 0 ? "Valor PAR." : "Valor ÍMPAR.";

            Console.WriteLine(msg);
            Console.ReadKey();
        }
    }
}
