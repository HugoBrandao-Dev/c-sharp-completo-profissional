using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula057
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            p1.nome = "Tobias de Oliveira";
            p1.email = "tobias@gmail.com";
            p1.cpf = "11111111111";
            p1.Cumprimentar();

            Pessoa p2 = new Pessoa();
            p2.nome = "Josias Cruz";
            p2.email = "josias@outlook.com";
            p2.cpf = "22222222222";
            p2.Cumprimentar();

            Console.ReadKey();
        }
    }
}
