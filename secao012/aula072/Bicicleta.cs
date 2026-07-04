using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula072
{
    internal class Bicicleta : Veiculo
    {
        public override void Acelerar()
        {
            Console.WriteLine("Acelerando bicicleta");
        }

        public override void Parar()
        {
            Console.WriteLine("Parou a bicicleta");
        }
        public void Pedalar()
        {
            Console.WriteLine("Pedalando...");
        }
    }
}
