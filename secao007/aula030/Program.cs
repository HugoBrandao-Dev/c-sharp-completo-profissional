using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula030
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 9;

            // num1 = num1 + 1;

            #region Operacoes com num1
            num1++;
            Console.WriteLine(--num1); // Antes de mostrar, ele diminui 1
            Console.WriteLine(num1++); // Mostra antes de somar
            #endregion

            #region Operacoes com num2
            num2--;
            Console.WriteLine(++num2); // Antes de mostrar, ele soma 1
            Console.WriteLine(num2--); // Mostra antes de diminuir
            #endregion
        }
    }
}
