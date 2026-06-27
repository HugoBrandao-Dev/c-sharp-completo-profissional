using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula042
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Calcula o delta */
            float a, b, c, delta;

            Console.Write("Valor de a: ");
            a = float.Parse(Console.ReadLine());

            Console.Write("Valor de b: ");
            b = float.Parse(Console.ReadLine());

            Console.Write("Valor de c: ");
            c = float.Parse(Console.ReadLine());

            delta = b * b - 4 * a * c;

            Console.WriteLine("\nO valor de DELTA é " + delta);

            if (delta < 0)
            {
                Console.WriteLine("A funcao NAO possui raizes reais.");
            } 
            else if (delta > 0) {
                Console.WriteLine("A funcao POSSUI DUAS raizes reais.");
            } 
            else
            {
                // Delta igual a ZERO
                Console.WriteLine("A funcao POSSUI DUAS raizes e elas sao IGUAIS");
            }
        }
    }
}
