using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace aula073
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=> Carro");
            Carro c1 = new Carro();
            c1.Marca = "Mitsubishi";
            c1.Cor = "Branco";
            c1.LigarMotor();
            c1.Acelerar();
            c1.DesligarMotor();

            Console.WriteLine("\n=> Bicicleta");
            Bicicleta b1 = new Bicicleta();
            b1.Marca = "Mormaii";
            b1.Cor = "Verde";
            b1.Pedalar();
            b1.Acelerar();

            Console.ReadKey();
        }
    }
}
