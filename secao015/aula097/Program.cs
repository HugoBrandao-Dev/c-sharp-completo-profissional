using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula097
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string nome = "Dinorá Oliveira";
            string nomeComDe = nome.Insert(7, "de "); // Add "de " na 7 posição

            Console.WriteLine(nomeComDe);
            Console.WriteLine(nomeComDe.Replace("Dinorá", "Tobias"));

        }
    }
}
