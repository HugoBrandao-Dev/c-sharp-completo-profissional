using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula101
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string nome = "  bTobias de Oliveira    ";
            char[] vogais = { ' ', 'a', 'b' }; // Sem o espaço, não remove o a de Oliveir->A<-
            string nomeSemVogais = nome.Trim(vogais);

            // .Trim() - Tira o espaço no inicio e no fim.
            Console.WriteLine("Sem espaço no início e no fim:");
            Console.WriteLine('|'+ nome.Trim() + '|');

            Console.WriteLine();

            // .TrimStart() - Tire o espaço no inicio.
            Console.WriteLine("Sem espaço no início:");
            Console.WriteLine('|' + nome.TrimStart() + '|');

            Console.WriteLine();

            // .TrimEnd() - Tire o espaço no fim.
            Console.WriteLine("Sem espaço no fim:");
            Console.WriteLine('|' + nome.TrimEnd() + '|');

            Console.WriteLine();

            // .Trim(<<PARAMETRO>>) - Tira o <<PARAMETRO>> de dentro da string
            Console.WriteLine("Sem espaço e as letras \'a\' e \'b\':");
            Console.WriteLine(nomeSemVogais);

            Console.ReadKey();

        }
    }
}
