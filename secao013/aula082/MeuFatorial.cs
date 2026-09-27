using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula082
{
    internal class MeuFatorial
    {
        public int CalcFatorial(int valor)
        {
            if (valor > 1)
            {
                return valor * CalcFatorial(valor - 1);
            }
            return 1;
        }
    }
}
