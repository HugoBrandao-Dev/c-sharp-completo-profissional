using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula117
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chave;
            int indice;
            bool isChaveExistente = false;
            string valor;
            bool isValorExistente = false;

            SortedList<int, string> meusValores = new SortedList<int, string>()
            {
                { 10, "Tobias" },
                { 5, "Josias" },
                { 6, "Dinorá" }
            };

            do
            {
                Console.Write("Chave [0 para sair]: ");
                chave = int.Parse(Console.ReadLine());

                isChaveExistente = meusValores.ContainsKey(chave);

                if (chave != 0 && !isChaveExistente)
                {

                    Console.Write("Valor: ");
                    valor = Console.ReadLine();

                    meusValores.Add(chave, valor);

                } else if (isChaveExistente) {
                    Console.WriteLine("\n--- Erro: A chave já existe.\n");
                }

            } while (chave != 0);

            Console.WriteLine($"\nValores já cadastrados [{ meusValores.Count }]:");
            foreach(KeyValuePair<int, string> item in meusValores)
            {
                Console.WriteLine($"{ item.Key } - { item.Value }");
            }

            Console.WriteLine("Qual item deseja remover?");
            do
            {
                Console.Write("Chave: ");
                chave = int.Parse(Console.ReadLine());
                isChaveExistente = meusValores.ContainsKey(chave);

                if (!isChaveExistente)
                {
                    Console.WriteLine("\n--- Erro: A chave não existe.\n");
                } else
                {

                    // A busca por um determinado valor, se dá através do uso de [<<CHAVE>>]
                    Console.WriteLine($"{ chave } - {meusValores[chave] } | Removido.");
                    meusValores.Remove(chave);

                }

            } while (!isChaveExistente);

            Console.WriteLine("\nLista decrescente:");
            foreach(KeyValuePair<int, string> item in meusValores.Reverse())
            {
                Console.WriteLine($"{ item.Key } - { item.Value }");
            }

            Console.WriteLine("Qual item deseja remover?");
            do
            {

                Console.Write("Valor: ");
                valor = Console.ReadLine();

                isValorExistente = meusValores.ContainsValue(valor);

                if (!isValorExistente)
                {

                    Console.WriteLine("\n--- Erro: O valor não existe.\n");

                } else
                {

                    indice = meusValores.IndexOfValue(valor);
                    Console.WriteLine($"{meusValores.Keys[indice]} - {valor} | Removido.");
                    meusValores.RemoveAt(indice);

                }

            } while (!isValorExistente);

            Console.ReadKey();
        }
    }
}
