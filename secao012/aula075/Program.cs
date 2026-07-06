using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula075
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teste t = new Teste();
            //t.nome = "";
            t.sobrenome = "";
            //t.MetodoUm();
            t.Executar();

            Homem h = new Homem();
            h.idade = 18;
        }
    }
}
