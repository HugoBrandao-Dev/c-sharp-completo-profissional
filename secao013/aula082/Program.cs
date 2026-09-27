using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula082
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MeuFatorial mf = new MeuFatorial();

            Console.Write("Fatorial\n>");
            int fat = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(mf.CalcFatorial(fat));

            Console.ReadKey();
        }
    }
}
