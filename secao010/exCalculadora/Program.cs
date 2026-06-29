using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula048
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float operando1, operando2, result;
            char operador, continuar;

        inicio:
            Console.Clear();
            Console.Write("Valor #1: ");
            operando1 = float.Parse(Console.ReadLine());

            Console.Write("Operação (+-*/): ");
            operador = char.Parse(Console.ReadLine());

            Console.Write("Valor #2: ");
            operando2 = float.Parse(Console.ReadLine());

            switch (operador)
            {
                case '+':
                    result = operando1 + operando2;
                    break;
                case '-':
                    result = operando1 - operando2;
                    break;
                case '*':
                    result = operando1 * operando2;
                    break;
                case '/':

                    if (operando2 == 0)
                    {
                        Console.WriteLine("\nNão é possível dividor por 0.\n");
                        goto inicio;
                    }

                    result = operando1 / operando2;
                    break;
                default:
                    Console.WriteLine("\nOperação inválida!!\n");
                    goto inicio;
            }

            Console.WriteLine("\n" + operando1 + " " + operador + " " + operando2 + " = " + result);

            Console.Write("\nContinuar? (s/n) ");
            continuar = char.Parse(Console.ReadLine());
            Console.WriteLine();

            if (continuar == 's' || continuar == 'S')
            {
                goto inicio;
            }

            Console.ReadKey();
        }
    }
}
