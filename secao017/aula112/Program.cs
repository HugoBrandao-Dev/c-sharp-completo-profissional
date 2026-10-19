using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace aula112
{
    internal class Program
    {
        static List<string> nomes = new List<string>();

        static void mostrarNomes()
        {
            foreach (string n in nomes)
            {
                Console.WriteLine(n);
            }
        }

        static void Main(string[] args)
        {

            string[] nomesArray = new string[3];
            nomesArray[0] = "Tobias";
            nomesArray[1] = "Dinorá";
            nomesArray[2] = "Josias";
            
            nomes.Add("Tobias");
            nomes.Add("Doralice");
            nomes.Add("Dinorá");

            Console.WriteLine("Sem adicionar o Array:");
            mostrarNomes();

            Console.WriteLine("\nArray adicionado:");
            nomes.AddRange(nomesArray);
            mostrarNomes();


            Console.ReadKey();
        }
    }
}
