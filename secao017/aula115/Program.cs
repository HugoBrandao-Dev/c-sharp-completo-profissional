using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula115
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> nomes = new Dictionary<int, string>();

            string nome;
            int chave;

            do
            {

                Console.Write("Nome [0 = SAIR]: ");
                nome = Console.ReadLine();

                if (nome != "0")
                {
                    Console.Write("Chave: ");
                    int.TryParse(Console.ReadLine(), out chave);
                    nomes.Add(chave, nome);
                }

            } while (nome != "0");

            Console.WriteLine();

            foreach (KeyValuePair<int, string> el in nomes)
            {
                Console.WriteLine(el.Key + " | " + el.Value);
            }

            Console.ReadKey();
        }
    }
}
