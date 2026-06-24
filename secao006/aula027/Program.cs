using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula027
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num1 = "1234";
            string num2 = "89709";
            char meuChar = 'h';
            bool haString = false;

            int meuNum1 = Convert.ToInt32(num1);
            Console.WriteLine(meuNum1);

            long meuNum2 = Convert.ToInt64(num2);
            Console.WriteLine(meuNum2);

            sbyte meuByte = Convert.ToSByte(meuChar);
            Console.WriteLine(meuByte);

            sbyte meuByteHaString = Convert.ToSByte(haString);
            Console.WriteLine(meuByteHaString);
            Console.WriteLine(Convert.ToBoolean(meuByteHaString));
        }
    }
}
