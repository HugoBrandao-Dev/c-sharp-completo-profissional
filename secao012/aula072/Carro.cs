using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula072
{
    internal class Carro : Veiculo
    {
        public short VelocidadeMaxima { get; set; }
        public override void Acelerar()
        {
            Console.WriteLine("Acelerando carro...");
        }

        public override void Parar()
        {
            Console.WriteLine("Parando carro...");
        }
        public void LigarMotor()
        {
            Console.WriteLine("Carro ligado.");
        }

        public void DesligarMotor()
        {
            Console.WriteLine("Carro desligado.");
        }

    }
}
