using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula058
{
    internal class Metodos
    {
        public void AumentarParametroValor(int valor)
        {
            valor += 10;
            Console.WriteLine("Por valor (+10): " + valor);
        }

        public void AumentarParametroReferencia(ref int valor)
        {
            valor += 5;
            Console.WriteLine("Por referência (+5): " + valor);
        }
    }
}
