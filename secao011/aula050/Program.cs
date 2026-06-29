using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula050
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            int valor = 0;

            do
            {
                Console.Write("Informe um valor (0 - SAIR): ");
                valor = int.Parse(Console.ReadLine());

                result += valor;
            }
            while (valor != 0);

            Console.WriteLine("\nA soma dos valores é " + result);
            Console.ReadKey();
        }
    }
}
