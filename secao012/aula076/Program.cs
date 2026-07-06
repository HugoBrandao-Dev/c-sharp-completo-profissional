using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula076
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Forma forma = new Forma();
            Forma triangulo = new Triangulo();
            Forma circulo = new Circulo();
            Forma retangulo = new Retangulo();

            //Console.WriteLine("=> Forma");
            //forma.Desenhar();
            Console.WriteLine("=> Triangulo");
            triangulo.Desenhar();
            Console.WriteLine("\n=> Circulo");
            circulo.Desenhar();
            Console.WriteLine("\n=> Retangulo");
            retangulo.Desenhar();

            Console.ReadKey();
        }
    }
}
