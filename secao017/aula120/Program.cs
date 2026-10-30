using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula120
{
    internal class Program
    {
        private static Queue<string> nomes = new Queue<string>();
        private static string[] opcoes =
        {
            "[1] Retornar o primeiro item",
            "[2] Retornar o último item",
            "[3] Remover o primeiro item",
            "[0] SAIR"
        };

        private static void MostrarMenu()
        {

            foreach(string o in opcoes)
            {
                Console.WriteLine(o);
            }

        }
        static void Main(string[] args)
        {
            string nome;
            byte opcaoUsuario;

            do
            {

                Console.Write("Nome a cadastrar [0 - SAIR]: ");
                nome = Console.ReadLine();

                if (!string.IsNullOrEmpty(nome))
                {

                    if (!nome.Equals("0"))
                    {

                        nomes.Enqueue(nome);

                    }

                } else
                {

                    Console.WriteLine("\n--- Erro: Nome inválido para cadastro.\n");

                }

            } while (!nome.Equals("0"));

            if (nomes.Count > 0)
            {
                do
                {

                    MostrarMenu();
                    Console.Write("> ");
                    if (byte.TryParse(Console.ReadLine(), out opcaoUsuario) && opcaoUsuario <= opcoes.Length)
                    {

                        switch (opcaoUsuario)
                        {
                            case 0:
                                Console.WriteLine("SAIU");
                                break;
                            case 1:
                                Console.WriteLine("Pelo .First(): " + nomes.First() + " | Pelo .Peek(): " + nomes.Peek());
                                break;
                            case 2:
                                Console.WriteLine("Último: " + nomes.Last());
                                break;
                            case 3:
                                Console.WriteLine("Nome removido: " + nomes.Dequeue());
                                break;
                        }

                    }
                    else
                    {
                        Console.WriteLine("\nOpção inválida");
                    }

                } while (opcaoUsuario != 0);

            } else
            {
                Console.WriteLine("Nada a mostrar.");
            }

        }
    }
}
