using System;
using System.Collections.Generic;
using System.Text;

namespace aula071
{
    internal class Carro : Veiculo
    {
        public short VelocidadeMaxima { get; set; }
        
        public void LigarMotor()
        {
            Console.WriteLine("O carro ligou o motor");
        }
    }
}
