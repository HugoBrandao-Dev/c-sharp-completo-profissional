using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula052
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nomes =
            {
                "Tobias de Oliveira",
                "Dinorá de Oliveira",
                "Josias Cruz",
                "Doralice Cruz"
            };

            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }

            Console.ReadKey();
        }
    }
}
