using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula043
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sbyte num;
            string msg;

            Console.Write("Informe um valor (0 - 10): ");
            num = sbyte.Parse(Console.ReadLine());

            if (num > 5)
            {
                msg = "O valor é acima da média ";
                if (num % 2 == 0)
                {
                    msg += "e PAR";
                } else
                {
                    msg += "e ÍMPAR";
                }
            } else
            {
                msg = "O valor é abaixo da média ";
                if (num % 2 == 0)
                {
                    msg += "e PAR.";
                } else
                {
                    msg += "e ÍMPAR.";
                }
            }

            Console.WriteLine(msg);
            Console.ReadKey();
        }
    }
}
