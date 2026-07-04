using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula073
{
    // sealed define que a classe nao pode ser herdada.
    sealed internal class Bicicleta : Veiculo
    {
        public override void Acelerar()
        {
            Console.WriteLine("Acelerando bicicleta");
        }

        public override void Parar()
        {
            Console.WriteLine("Parando bicicleta");
        }

        public void Pedalar()
        {
            Console.WriteLine("Pedalando...");
        }
    }
}
