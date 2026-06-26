using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula039
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz1 = new int[2, 3];
            int[,] matriz2 = new int[3, 2];
            int[,] prodMatricial = new int[2, 2];

            /* ### MULTIPLICADOR DE MATRIZES (2,3)x(3,2) ### */

            /* Matriz #1 */

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("A(" + i + ", " + j + "): ");
                    matriz1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine();

            /* Matriz #2 */

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("B(" + i + ", " + j + "): ");
                    matriz2[i, j] = int.Parse(Console.ReadLine());
                }
            }

            prodMatricial[0, 0] = (matriz1[0, 0] * matriz2[0, 0]) + (matriz1[0, 1] * matriz2[1, 0]) + (matriz1[0, 2] * matriz2[2, 0]);
            prodMatricial[0, 1] = (matriz1[0, 0] * matriz2[0, 1]) + (matriz1[0, 1] * matriz2[1, 1]) + (matriz1[0, 2] * matriz2[2, 1]);
            prodMatricial[1, 0] = (matriz1[1, 0] * matriz2[0, 0]) + (matriz1[1, 1] * matriz2[1, 0]) + (matriz1[1, 2] * matriz2[2, 0]);
            prodMatricial[1, 1] = (matriz1[1, 0] * matriz2[0, 1]) + (matriz1[1, 1] * matriz2[1, 1]) + (matriz1[1, 2] * matriz2[2, 1]);

            Console.WriteLine("\n=> Produto Matricial:");
            Console.WriteLine("|" + prodMatricial[0,0] + " " + prodMatricial[0,1] + "|");
            Console.WriteLine("|" + prodMatricial[1,0] + " " + prodMatricial[1,1] + "|");

            Console.ReadKey();
        }
    }
}
