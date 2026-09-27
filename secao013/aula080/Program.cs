using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula080
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Recursivo r1 = new Recursivo();

            // Não recursivo
            r1.Executar("C# (C Sharp)", 5);

            // Faz a mesma coisa, mas de forma recursiva.
            Console.WriteLine("\n=> Recursivo");
            r1.ExecutarRecursivo("C# (C Sharp)", 5);

            Console.ReadKey();
        }
    }
}
