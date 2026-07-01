using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula056
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            p1.nome = "Tobias de Oliveira";
            p1.email = "tobias@gmail.com";
            p1.cpf = "11111111111";

            Pessoa p2 = new Pessoa()
            {
                nome = "Doralice Cruz",
                email = "dora@yahoo.com",
                cpf = "22222222222"
            };

            p1.nome = "Dinorá de Oliveira";
            p1.email = "dino@hotmail.com";

            Console.WriteLine("#1 Pessoa");
            Console.WriteLine("Nome: " + p1.nome);
            Console.WriteLine("Email: " + p1.email);

            Console.WriteLine("\n#2 Pessoa");
            Console.WriteLine("Nome: " + p2.nome);
            Console.WriteLine("Email: " + p2.email);

            Console.ReadKey();
        }
    }
}
