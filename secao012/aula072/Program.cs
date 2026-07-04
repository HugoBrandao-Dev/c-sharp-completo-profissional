using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula072
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=> Carro");
            Carro c1 = new Carro();
            c1.Marca = "Honda";
            c1.Cor = "Azul";
            c1.LigarMotor();
            c1.Acelerar();
            c1.Parar();
            c1.DesligarMotor();

            Console.WriteLine("\n=> Bicicleta");
            Bicicleta b1 = new Bicicleta();
            b1.Marca = "Caloi Poti";
            b1.Cor = "Branco";
            b1.Pedalar();
            b1.Acelerar();
            b1.Parar();

            /*
             * Não irá mais funcionar, pq foi definido que a classe
             * é abstrata.
             * 
            Console.WriteLine("\n=>Veiculo");
            Veiculo v1 = new Veiculo();
            v1.Acelerar();
            */
        }
    }
}
