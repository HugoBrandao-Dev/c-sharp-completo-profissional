using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Saída
            Console.WriteLine("Apenas uma saída com quebra de linha.");

            // Saída sem quebra de linha.
            Console.Write("Informe seu nome: ");
            string nome = Console.ReadLine(); // Entradas qualquer

            Console.Write("Informe sua idade: ");
            int idade = Console.Read(); // Entradas do tipo numerico

            Console.WriteLine(nome);
            Console.WriteLine(idade);

            // Entrada de apenas uma tecla
            Console.ReadKey();
        }
    }
}
