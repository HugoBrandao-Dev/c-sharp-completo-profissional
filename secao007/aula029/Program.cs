using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula029
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num1 = 100;
            float num2 = 13;
            float num3 = 4;

            float result = (num2 / (num1 + num2 + num3)) * 100;

            Console.WriteLine(result);
        }
    }
}
