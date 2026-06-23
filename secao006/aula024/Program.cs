using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * O ushort comporta o valor de byte.
             */
            byte meuByte = 100; // 8 bits, de 0 a 255
            ushort meuUShort; // 16 bits, 0 a 65.535
            meuUShort = meuByte;
            Console.WriteLine(meuUShort);

            /*
             * O double comporta o valor de float.
             */
            float meuFloat = 1250.45f;
            double meuDouble = meuFloat;
            Console.WriteLine(meuDouble);

            /*
             * int comporta o VALOR (ASCII) de letra.
             */
            char letra = 'h';
            int numChar = letra;
            Console.WriteLine(numChar);
        }
    }
}
