using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula033
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool resultIguais = 100 == 50 * 2.1;
            bool resultDif = 25 != 22;

            string nome = "Josias";
            bool nomesIguais = nome == "Josias";

            Console.WriteLine("100 == 50 * 2.1");
            Console.WriteLine(resultIguais);

            Console.WriteLine("\n25 != 22");
            Console.WriteLine(resultDif);

            Console.WriteLine("\nJosias == Josias");
            Console.WriteLine(nomesIguais);
        }
    }
}
