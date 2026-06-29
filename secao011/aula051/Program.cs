using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula051
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short cont;

        inicio:
            Console.WriteLine("Posso contar até 1000");
            Console.WriteLine("Até quanto deseja que eu conte? ");
            Console.Write("> ");
            cont = short.Parse(Console.ReadLine());

            if (cont < 0 || cont > 1000)
            {
                Console.WriteLine("\nOPS!! Valor inválido.\n");
                goto inicio;
            }

            for (short i = 0, j = cont; i <= cont; i++, j--)
            {
                Console.WriteLine(i + " - " + j); // i vai de 0 até o valor; j vai do valor até 0.
            }

            Console.WriteLine("\nPronto. Terminei a contagem!!");
            Console.ReadKey();
        }
    }
}
