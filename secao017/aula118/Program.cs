using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace aula118
{
    internal class Program
    {
        private static SortedDictionary<int, string> nomes = new SortedDictionary<int, string>();

        private static void mostrarElementosDictionary()
        {
            Console.WriteLine("\nNome cadastrados: " + nomes.Count);
            foreach (KeyValuePair<int, string> item in nomes)
            {

                Console.WriteLine($"{ item.Key } - { item.Value }");

            }

        }

        static void Main(string[] args)
        {

            int chave;
            int chaveParaExcluir;

            string nome;

            bool hasChave;
            bool hasNome;

            do
            {

                mostrarElementosDictionary();
                Console.Write("\nChave [0 - SAIR]: ");
                int.TryParse(Console.ReadLine(), out chave);

                if (chave != 0)
                {

                    hasChave = nomes.ContainsKey(chave);

                    if (hasChave)
                    {

                        Console.WriteLine("\n--- Erro: A chave já foi cadastrada.\n");

                    } else
                    {

                        Console.Write("Nome: ");
                        nome = Console.ReadLine();

                        hasNome = nomes.ContainsValue(nome);

                        if (hasNome)
                        {

                            Console.WriteLine("\n--- Erro: O nome já foi cadastrado.\n");

                        } else
                        {

                            nomes.Add(chave, nome);

                        }

                    }
                }

            } while (chave != 0);

            if (nomes.Count > 0)
            {
                Console.Write("\nQual chave deseja excluir: ");
                if (int.TryParse(Console.ReadLine(), out chaveParaExcluir))
                {

                    if (nomes.ContainsKey(chaveParaExcluir))
                    {

                        nomes.Remove(chaveParaExcluir);
                        Console.WriteLine("Removida com sucesso.");
                        mostrarElementosDictionary();

                    }

                }
            }

            Console.ReadLine();
        }
    }
}
