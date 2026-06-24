using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula028
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 13;
            int num2 = 2;

            Console.WriteLine("Para os valores 13 e 2:");

            Console.Write("Soma -> ");
            Console.WriteLine(num1 + num2);

            Console.Write("Diferenca -> ");
            Console.WriteLine(num1 - num2);

            Console.Write("Multiplicacao -> ");
            Console.WriteLine(num1 * num2);

            Console.Write("Divisao -> ");
            Console.WriteLine(num1 / num2); // Por algum motivo, nao mostra as casa decimais...

            Console.Write("Resto da divisao: ");
            Console.WriteLine(num1 % num2);
        }
    }
}
