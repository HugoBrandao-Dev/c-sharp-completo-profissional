using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula063
{
    internal class Matematica
    {
        public void Somar(int num1, int num2)
        {
            Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2));
        }

        public void Subtrair(int num1, int num2)
        {
            Console.WriteLine(num1 + " - " + num2 + " = " + (num1 - num2));
        }

        public void Multiplicar(int num1, int num2)
        {
            Console.WriteLine(num1 + " * " + num2 + " = " + (num1 * num2));
        }

        public void Dividir(int num1, int num2)
        {
            Console.WriteLine(num1 + " / " + num2 + " = " + (num1 / num2));
        }
    }
}
