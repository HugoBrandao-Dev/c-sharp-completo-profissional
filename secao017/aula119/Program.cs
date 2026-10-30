using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace aula119
{
    internal class Program
    {
        private static SortedSet<int> valores = new SortedSet<int>();

        private static void mostrarValores(char tipo)
        {

            switch (tipo)
            {
                // Ordenar crescente
                case 'c':
                    Console.WriteLine("\nValor ordenados (decrescente): ");
                    foreach (byte v in valores)
                    {

                        Console.WriteLine(v);

                    }
                    break;
                // Ordenar descrescente
                case 'd':
                    Console.WriteLine("\nValor ordenados (decrescente): ");
                    foreach (byte v in valores.Reverse())
                    {

                        Console.WriteLine(v);

                    }
                    break;
                default:
                    Console.WriteLine("\n--- Erro: Opção de ordamento inválida.\n");
                    break;
            }

        }

        static void Main(string[] args)
        {

            byte valor;
            byte valorParaExcluir;

            do
            {

                Console.Write("Digite uma valor [1-100 | 0 - SAIR]: ");
                if (byte.TryParse(Console.ReadLine(), out valor))
                {

                    if (valor >= 1 && valor <= 100)
                    {

                        valores.Add(valor);

                    } else if (valor == 0)
                    {

                        Console.WriteLine("SAIU");

                    } else
                    {

                        Console.WriteLine("\nValor inválido\n");

                    }

                } else
                {
                    Console.WriteLine("\n--- Erro: Valor inválido;\n");
                }

            } while (valor != 0);

            mostrarValores('c');
            mostrarValores('d');

            Console.WriteLine("\nQual valor deseja excluir?");
            Console.Write("> ");
            if (byte.TryParse(Console.ReadLine(), out valorParaExcluir))
            {

                if (valorParaExcluir >= 1 && valorParaExcluir <= 100 && valores.Contains(valorParaExcluir))
                {

                    valores.Remove(valorParaExcluir);
                    Console.WriteLine("Valor removido");
                    mostrarValores('c');

                } else
                {
                    Console.WriteLine("Valor inválido");
                }

            } else
            {

                Console.WriteLine("\n--- Erro: O valor é inválido\n");

            }


            Console.ReadKey();
        }
    }
}
