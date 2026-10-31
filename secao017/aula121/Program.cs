using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula121
{
    internal class Program
    {
        private static Stack<string> nomes = new Stack<string>();
        private static string[] opcoesMenu =
        {
            "[1] Adicionar nome",
            "[2] Último nome adicionado",
            "[3] Remover último nome",
            "[4] Limpar Stack",
            "[0] SAIR"
        };

        private static void MostrarMenu()
        {

            Console.WriteLine("OPÇÕES");
            foreach(string o in opcoesMenu)
            {
                Console.WriteLine(o);
            }

        }

        private static void MostrarNomes()
        {

            if (nomes.Count > 0)
            {
                Console.WriteLine();
                foreach (string n in nomes)
                {

                    Console.WriteLine(n);

                }
                Console.WriteLine();

            } else
            {

                Console.WriteLine("Nenhum nome cadastrado");

            }

        }

        static void Main(string[] args)
        {

            byte opcaoUsuario;

            string nome;

            do
            {
                MostrarNomes();
                MostrarMenu();
                Console.Write("> ");
                if (byte.TryParse(Console.ReadLine(), out opcaoUsuario))
                {

                    if (opcaoUsuario >= 0 && opcaoUsuario < opcoesMenu.Length)
                    {

                        switch (opcaoUsuario)
                        {
                            case 0:

                                Console.WriteLine("SAIU");
                                break;

                            case 1:

                                Console.Write("Nome: ");
                                nome = Console.ReadLine();

                                if (!string.IsNullOrEmpty(nome))
                                {

                                    nomes.Push(nome);
                                    Console.WriteLine(nome + " adicionado com sucesso.");

                                } else
                                {
                                    Console.WriteLine("Nome inválido");
                                }

                                break;

                            case 2:

                                Console.WriteLine("O último nome adicionado foi " + nomes.Peek());
                                break;

                            case 3:

                                Console.WriteLine(nomes.Pop() + " foi retirado.");
                                break;

                            case 4:

                                nomes.Clear();
                                Console.WriteLine("Stack limpa!");
                                break;

                            default:

                                Console.WriteLine("\n--- Erro: A opção não existe.\n");
                                break;
                        }

                    } else
                    {
                        Console.WriteLine("\nOpção inválida");
                    }

                } else
                {
                    Console.WriteLine("\n--- Erro: O valor é inválido.\n");
                }

            } while (opcaoUsuario != 0);

            Console.ReadKey();

        }
    }
}
