using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula038
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Matriz de inteiros
            int[,] minhaMatriz = new int[3, 3];

            minhaMatriz[0, 0] = 1;
            minhaMatriz[0, 1] = 0;
            minhaMatriz[0, 1] = 0;

            minhaMatriz[1, 0] = 0;
            minhaMatriz[1, 1] = 1;
            minhaMatriz[1, 2] = 0;

            minhaMatriz[2, 0] = 0;
            minhaMatriz[2, 1] = 0;
            minhaMatriz[2, 2] = 1;

            Console.WriteLine("|" + minhaMatriz[0, 0] + " " + minhaMatriz[0, 1] + " " + minhaMatriz[0, 2] + "|");
            Console.WriteLine("|" + minhaMatriz[1, 0] + " " + minhaMatriz[1, 1] + " " + minhaMatriz[1, 2] + "|");
            Console.WriteLine("|" + minhaMatriz[2, 0] + " " + minhaMatriz[2, 1] + " " + minhaMatriz[2, 2] + "|");
            #endregion

            #region Matriz de strings
            string[,] matrizNomes =
            {
                { "Tobias", "Dinorá" },
                { "Josias", "Doralice" }
            };

            Console.WriteLine(matrizNomes[0, 0]);
            Console.WriteLine(matrizNomes[1, 1]);
            #endregion

            Console.ReadKey();
        }
    }
}
