using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ushort meuUShort = 100;
            byte meuByte = (byte)meuUShort; // Forca a conversao
            Console.WriteLine(meuByte);

            int meuInt = 100000;
            short meuShort = (short)meuInt;
            Console.WriteLine(meuShort);

            float meuFloat = 123f;
            int meuInt2 = (int)meuFloat;
            Console.WriteLine(meuInt2);

            char meuChar = (char)meuUShort;
            char meuChar2 = (char)25;
            Console.WriteLine(meuChar);
            Console.WriteLine(meuChar2);
        }
    }
}
