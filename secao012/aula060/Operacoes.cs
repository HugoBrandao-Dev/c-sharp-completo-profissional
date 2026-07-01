using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula060
{
    internal class Operacoes
    {
        public float Somar(float a, float b)
        {
            return a + b;
        }

        public float Subtrair(float a, float b)
        {
            return a - b;
        }

        public float Multiplicar(float a, float b)
        {
            return a* b;
        }

        // Há um problema com essa funcao, pq pode nao consigo retornar algo q nao seja matematico.
        public float Dividir(float a, float b)
        {
            if (b == 0)
            {
                Console.WriteLine("Não é possivel uma divisão por zero");
                return '=';
            }
            return a / b;
        }
    }
}
