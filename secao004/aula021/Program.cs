using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula021
{
    internal class Program
    {
        struct Pessoa
        {
            public string nome;
            public string cpf;
            public int qtdAcessos;
        }

        static void Main(string[] args)
        {
            #region Atributos fora da declaracao
            Pessoa p1 = new Pessoa();
            p1.nome = "Doralice";
            p1.cpf = "11111111111";
            p1.qtdAcessos = 32;
            #endregion

            #region Atributos dentro da declaracao
            Pessoa p2 = new Pessoa()
            {
                nome = "Josias",
                cpf = "22222222222",
                qtdAcessos = 98
            };
            #endregion

            Console.WriteLine(p1.nome);
            Console.WriteLine(p1.cpf);
            Console.WriteLine(p1.qtdAcessos);

            // Quebra de linha.
            Console.WriteLine();

            Console.WriteLine(p2.nome);
            Console.WriteLine(p2.cpf);
            Console.WriteLine(p2.qtdAcessos);
        }
    }
}
