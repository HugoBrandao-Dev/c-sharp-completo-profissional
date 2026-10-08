using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace aula102
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string nome1 = "Tobias";
            string nome2 = "Roberto";

            Console.WriteLine(nome1 + " <-> " + nome2);

            Console.WriteLine();

            // Compara se os nomes são iguais
            if (nome1.Equals(nome2))
            {
                Console.WriteLine("Os nomes são iguais");
            } else
            {
                Console.WriteLine("Os nomes são diferentes");
            }

            // Verifica a posicao de nome1 com relacao a nome2 (-1 - antes, 0 - mesma, 1 - depois)
            switch (nome1.CompareTo(nome2))
            {
                case -1: // nome1 vem antes de nome2
                    Console.WriteLine(nome1 + " vem antes " + nome2);
                    break;
                case 0: // nome1 esta na mesma posicao de nome2
                    Console.WriteLine("Estão na mesma posição");
                    break;
                case 1: // nome1 vem depois de nome2
                    Console.WriteLine(nome2 + " -> " + nome1);
                    break;
            }

            Console.ReadKey();

        }
    }
}
