using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace aula061
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string txt1, txt2;
            int num1, num2, opcao;

            Sobrecarga sc = new Sobrecarga();

            sc.Cumprimentar("Tobias", 12);

            Console.WriteLine("O que deseja comparar?");
            Console.WriteLine("1 - Números.");
            Console.WriteLine("2 - Textos");
            opcao = int.Parse(Console.ReadLine());

            Console.WriteLine();

            switch (opcao)
            {
                case 1:
                    Console.Write("Valor #1: ");
                    num1 = int.Parse(Console.ReadLine());

                    Console.Write("Valor #2: ");
                    num2 = int.Parse(Console.ReadLine());

                    if (sc.Comparar(num1, num2))
                    {
                        Console.WriteLine("São iguais.");
                    } else
                    {
                        Console.WriteLine("São diferentes.");
                    }

                    break;
                case 2:
                    Console.Write("Texto #1: ");
                    txt1 = Console.ReadLine();

                    Console.Write("Texto #2: ");
                    txt2 = Console.ReadLine();

                    if (sc.Comparar(txt1, txt2))
                    {
                        Console.WriteLine("São iguais.");
                    } else
                    {
                        Console.WriteLine("São diferentes.");
                    }

                    break;
                default:
                    Console.WriteLine("\nOpção inválida.\n");
                    break;
            }

            Console.ReadKey();
        }
    }
}
