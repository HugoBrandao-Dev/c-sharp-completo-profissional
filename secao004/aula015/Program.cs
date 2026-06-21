using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula015
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool meuBool = true;

            bool falso = false;

            falso = meuBool;

            Console.WriteLine(meuBool);
            Console.WriteLine(falso);
        }
    }
}
