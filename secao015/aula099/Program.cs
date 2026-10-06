using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula099
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string nomeString = "Tobias de Oliveira Silva";

            char[] vogais = { 'a', 'e', 'i', 'o', 'u' };
            string[] palavraSplit = { " de " };

            string[] nomeSemEspaco = nomeString.Split(' ');
            string[] nomeSemDe = nomeString.Split(palavraSplit, StringSplitOptions.None);
            string[] nomeSemVogais = nomeString.ToLower().Split(vogais);

            foreach (string n in nomeSemEspaco)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("\nSem de: ");
            
            foreach (string n in nomeSemDe)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("\nSem vogais: ");

            foreach (string n in nomeSemVogais)
            {
                Console.WriteLine(n);
            }
            
            Console.ReadKey();

        }
    }
}
