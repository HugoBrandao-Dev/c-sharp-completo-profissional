using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte meuByte = byte.Parse("123");
            Console.WriteLine(meuByte);

            // Dara erro, pq tem letra no valor
            // ushort meuUshort = ushort.Parse("918a");

            long meuLong = long.Parse("1000000");
            Console.WriteLine(meuLong);

            float meuFloat = float.Parse("123,321");
            Console.WriteLine(meuFloat);
        }
    }
}
