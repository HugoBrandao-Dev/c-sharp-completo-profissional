using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula020
{
    internal class Program
    {
        enum Notas
        { // O valor padrao e o indice, caso contrario, e valor, valor+1, valor+2...
            min, med = 21, max
        }
        static void Main(string[] args)
        {
            Notas notasAluno = Notas.med;
        }
    }
}
