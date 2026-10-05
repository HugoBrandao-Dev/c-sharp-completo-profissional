using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula095
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string nome = "tObIaS";

            string nomeTransformado = nome.ToUpper();
            Console.WriteLine(nomeTransformado);

            nomeTransformado = nome.ToLower();
            Console.WriteLine(nomeTransformado);

            Console.ReadKey();
        }
    }
}
