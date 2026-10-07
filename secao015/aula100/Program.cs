using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula100
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string item = "Draconic Bow";
            string comeco = "Shi";
            string fim = "Bow";

            Console.WriteLine(item);
            Console.WriteLine();
            Console.WriteLine("Começa com " + comeco + "? " + item.StartsWith(comeco));

            // O C# é case-sensitive
            Console.WriteLine("Começa com dra? " + item.StartsWith("dra"));

            // Ignora o case-sensitive
            Console.WriteLine("Começa com dra? " + item.StartsWith("dra", StringComparison.OrdinalIgnoreCase));

            Console.WriteLine("Termina com " + fim + "? " + item.EndsWith(fim));

            Console.ReadKey();

        }
    }
}
