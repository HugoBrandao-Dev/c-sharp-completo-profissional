using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula034
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma = 45 + 60;
            int div = 100 / 2;

            // Operadores aritmeticos tem prioridade a cima dos relacionais
            bool menor = 100 < soma;
            Console.WriteLine("100 < 45 + 60");
            Console.WriteLine(menor);

            bool maior = 50 > 30 * 2;
            Console.WriteLine("\n50 > 30 * 2");
            Console.WriteLine(maior);

            bool menorIgual = 41 <= 20 + 21;
            Console.WriteLine("\n41 <= 20 + 21");
            Console.WriteLine(menorIgual);

            bool maiorIgual = 39 >= div;
            Console.WriteLine("\n39 >= 100 / 2");
            Console.WriteLine(maiorIgual);
        }
    }
}
