using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula037
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Array de strings
            string[] nomes = new string[4];

            nomes[0] = "Tobias de Oliveira";
            nomes[1] = "Dinorá de Oliveira";
            nomes[2] = "Josias Cruz";
            nomes[3] = "Doralice Cruz";

            nomes[2] = "Hugo da Rocha";

            // Da erro, por estar fora do tamanho maximo do array (4).
            //nomes[4] = "Não é possivel";

            Console.WriteLine(nomes[0]);
            Console.WriteLine(nomes[2]);
            #endregion

            #region Array de inteiros
            int[] idades = new int[4];
            idades[0] = 31;
            idades[1] = 38;
            idades[2] = 32;
            idades[3] = 32;

            idades[1] = 100;

            Console.WriteLine(idades[1]);
            Console.WriteLine(idades[3]);
            #endregion

            #region Array fracionarios
            double[] constantes = { 2.7183, 3.1415 };

            // Da erro, por ser de tipo diferente do array.
            //constantes[0] = "uai!!";
            constantes[1] = 3.1416;

            Console.WriteLine(constantes[1]);
            #endregion
        }
    }
}
