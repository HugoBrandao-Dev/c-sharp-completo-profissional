using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula047
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            int valor = 0;

            opcoes:
            Console.WriteLine("Opções:");
            Console.WriteLine("1 - Valor base (100);");
            Console.WriteLine("2 - Valor de 50;");

            Console.Write("> ");
            opcao = int.Parse(Console.ReadLine());

            if (opcao >= 1 && opcao <= 2)
            {
                switch (opcao)
                {
                    default:
                        break;
                    case 1: // Valor base
                        valor += 100;
                        break;
                    case 2:
                        valor += 50;
                        goto case 1; // Para somar com o valor base.
                }

                Console.WriteLine("\nValor final: " + valor);
            } else
            {
                Console.WriteLine("\nOpção inválida!!");
                goto opcoes;
            }
            
            Console.ReadKey();
        }
    }
}
