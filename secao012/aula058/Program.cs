using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula058
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int val1, val2;
            short ano;
            string nome;
            Metodos met = new Metodos();

            met.Apresentacao();

            Console.Write("Seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Ano atual: ");
            ano = short.Parse(Console.ReadLine());

            met.Cumprimentar(nome, ano);

            Console.Write("Valor #1: ");
            val1 = int.Parse(Console.ReadLine());

            Console.Write("Valor #2: ");
            val2 = int.Parse(Console.ReadLine());

            met.Somar(val1, val2);

            Console.ReadKey();
        }
    }
}
