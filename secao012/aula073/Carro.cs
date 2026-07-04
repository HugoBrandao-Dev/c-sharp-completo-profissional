using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula073
{
    internal class Carro : Veiculo
    {
        public string VelocidadeMaxima { get; set; }

        public override void Acelerar()
        {
            Console.WriteLine("Acelerando o carro.");
        }

        public override void Parar()
        {
            Console.WriteLine("Parando o carro.");
        }

        public void LigarMotor()
        {
            Console.WriteLine("Motor do carro ligado.");
        }

        public void DesligarMotor()
        {
            Console.WriteLine("Motor do carro desligado.");
        }
    }
}
