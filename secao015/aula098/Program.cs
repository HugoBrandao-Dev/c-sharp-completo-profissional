using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace aula098
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string nome = "Josias Cruz";
            string sobrenome;
            string trecho;

            int tamanho = nome.Length;
            int posicaoEspaco = nome.IndexOf(' ');

            sobrenome = nome.Substring(posicaoEspaco + 1);
            trecho = nome.Substring((posicaoEspaco + 1), 2);

            Console.WriteLine(nome + " tem " + tamanho + " caracteres.");
            Console.WriteLine(sobrenome);
            Console.WriteLine(trecho);

            Console.ReadKey();

        }
    }
}
