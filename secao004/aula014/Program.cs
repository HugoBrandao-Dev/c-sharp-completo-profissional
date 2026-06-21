using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Caracteres
            char minhaLetra = 'h'; // Literal
            char letraCodigo = '\u0041';
            char escape = '\n';
            char barraInver = '\\';
            #endregion

            Console.WriteLine(minhaLetra);
            Console.WriteLine(escape);
            Console.WriteLine(letraCodigo);
            Console.WriteLine(barraInver);
        }
    }
}
