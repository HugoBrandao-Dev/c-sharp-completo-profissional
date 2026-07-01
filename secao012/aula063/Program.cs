using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula063
{
    internal class Program
    {
        delegate void Operacao(int n1, int n2);
        static void Main(string[] args)
        {
            int num1, num2;

            Matematica mate = new Matematica();
            Operacao conta = null;
            conta = mate.Somar;

            Console.Write("#1 valor: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("#2 valor: ");
            num2 = int.Parse(Console.ReadLine());

            conta(num1, num2);

            Console.ReadKey();
        }
    }
}
