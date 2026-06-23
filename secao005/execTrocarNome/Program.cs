using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exInverterNome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome1, nome2, nome3, nome4, nomeTemp;

            Console.Write("1º Nome: ");
            nome1 = Console.ReadLine();

            Console.Write("2º Nome: ");
            nome2 = Console.ReadLine();

            Console.Write("3º Nome: ");
            nome3 = Console.ReadLine();

            Console.Write("4º Nome: ");
            nome4 = Console.ReadLine();

            // Troca o primeiro pelo último
            nomeTemp = nome4;
            nome4 = nome1;
            nome1 = nomeTemp;

            // Troca o segundo pelo terceiro
            nomeTemp = nome3;
            nome3 = nome2;
            nome2 = nomeTemp;


            Console.WriteLine("\nOrdem inversa:");
            Console.WriteLine(nome1);
            Console.WriteLine(nome2);
            Console.WriteLine(nome3);
            Console.WriteLine(nome4);
        }
    }
}
