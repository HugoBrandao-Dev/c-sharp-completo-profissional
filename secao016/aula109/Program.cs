using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula109
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int exInteiro = 12;
            float exDecimal = 211.125f;

            Console.WriteLine(exInteiro.ToString("0000"));
            Console.WriteLine(exDecimal.ToString("0000.00")); // Já arredonda!!
            Console.WriteLine(exDecimal.ToString("#.00"));

            // Converte em hexadecimal
            Console.WriteLine(exInteiro.ToString("x")); // ou "X" ou "X4" (no mínimo 4 números)

            // Para decimal
            Console.WriteLine(exInteiro.ToString("D"));
            Console.WriteLine(exInteiro.ToString("d4"));

            Console.WriteLine(exDecimal.ToString("C")); // ou "c"

            Console.WriteLine(Convert.ToString(exInteiro, 16)); // Converte para HEX



            Console.ReadKey();

        }
    }
}
