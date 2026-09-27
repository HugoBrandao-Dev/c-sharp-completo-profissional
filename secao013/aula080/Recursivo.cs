using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace aula080
{
    internal class Recursivo
    {
        /**
         * @n É a quantidade de vezes que esse método irá repetir
         */
        public void Executar(string msg, int n)
        {
            
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(msg);
            }
            
        }

        public void ExecutarRecursivo(string msg, int n)
        {

            if (n > 0)
            {
                Console.WriteLine(msg);
                ExecutarRecursivo(msg, n - 1);
            }

        }
    }
}
