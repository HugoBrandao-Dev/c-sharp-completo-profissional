using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula058
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor1 = 100;
            int valor2 = 100;
            Metodos meuMetodo = new Metodos();

            // Parâmetro por valor.
            meuMetodo.AumentarParametroValor(valor1);
            Console.WriteLine(valor1);

            Console.WriteLine();

            // Parâmetro por referência.
            meuMetodo.AumentarParametroReferencia(ref valor2);
            Console.WriteLine(valor2);

            Console.ReadKey();
        }
    }
}
