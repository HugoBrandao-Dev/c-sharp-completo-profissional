using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula081
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Essas variáveis são desnecessárias, pode-se passar diretamente os args[0] e args[1].
            string nome = args[0];
            string senhaPassada = args[1];

            string senha = "abc123";

            if (senhaPassada != senha)
            {
                Console.WriteLine("Senha inválida");
            } else
            {
                Console.WriteLine("[Logado]");
                Console.WriteLine("Bem vindo, " + nome);
            }

            Console.ReadKey();
        }
    }
}
