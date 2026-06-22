using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula018
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object meuObj = "Josias";
            Console.WriteLine(meuObj);

            /*
             * Mesmo sendo declarada com valor do tipo string,
             * pode ser mudado por outro tipo.
             */
            meuObj = 200;
            Console.WriteLine(meuObj);
        }
    }
}
