using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula062
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string senha;
            bool logado = false;

            Acessar acessar = new Acessar();

            do
            {
                Console.Write("Digite sua senha: ");
                senha = Console.ReadLine();

                logado = acessar.Login(senha);

                if (!logado)
                {
                    Console.Clear();
                    Console.WriteLine("Senha inválida.\n");
                }
            } while (!logado);

            Console.WriteLine("\nLogado com sucesso!!!");
            Console.ReadKey();
        }
    }
}
