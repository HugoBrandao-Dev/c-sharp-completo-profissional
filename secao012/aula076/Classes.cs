using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula076
{
    abstract internal class Forma
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public float Altura { get; set; }
        public float Largura { get; set; }
        public int Raio { get; set; }

        public virtual void Desenhar()
        {
            Console.WriteLine("Preparando-se para desenhar.");
        }

        public virtual void Area() {
            float area = Largura * Altura;
            Console.WriteLine("Area: " + area);
        }
    }

    internal class Circulo : Forma
    {
        public override void Desenhar()
        {
            base.Desenhar();
            Console.WriteLine("Desenhando um Circulo.");
        }

        public override void Area()
        {
            float area = 3.1416f * (Raio * Raio);
            Console.WriteLine("Area Circulo: " + area);
        }
    }

    internal class Retangulo : Forma
    {
        public override void Desenhar()
        {
            base.Desenhar();
            Console.WriteLine("Desenhando um Retangulo.");
        }

        public override void Area()
        {
            base.Area();
        }
    }

    internal class Triangulo : Forma
    {
        public override void Desenhar()
        {
            base.Desenhar();
            Console.WriteLine("Desenhando um Triangulo.");
        }

        public override void Area()
        {
            float area = (Largura * Altura) / 2;
            Console.WriteLine("Area Triangulo: " + area);
        }
    }
}
