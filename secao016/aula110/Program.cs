using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula110
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double pi = Math.PI;
            double meuE = Math.E;
            double seno = Math.Sin(3);
            double conseno = Math.Cos(3);
            double potencia = Math.Pow(5, 3);
            double raizQuadrada = Math.Sqrt(25);
            double arredondarInteiro = Math.Round(123.593);
            double arredondarComCasasDecimais = Math.Round(123.593, 2);
            double arredBaixo = Math.Floor(32.56);
            double arredCima = Math.Ceiling(21.23); // Não é Ceil.

            Console.WriteLine(pi.ToString("#.00"));
            Console.WriteLine("5³ = " + potencia.ToString());
            Console.WriteLine("Raiz de 25: " + raizQuadrada);
            Console.WriteLine("Arredondamente para inteiro: " + arredondarInteiro);
            Console.WriteLine("Arredondamente para inteiro: " + arredondarComCasasDecimais);
            Console.WriteLine("Arredondando para baixo: " + arredBaixo);
            Console.WriteLine("Arredondando para cima: " + arredCima);

            Console.ReadKey();
        }
    }
}
