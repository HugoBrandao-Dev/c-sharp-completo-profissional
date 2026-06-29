using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula049
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;

            // O código abaixo irá contar até 10.
            while (cont <= 10)
            {
                Console.WriteLine("Valor #" + cont);
                cont++;
            }

            Console.ReadKey();
        }
    }
}
