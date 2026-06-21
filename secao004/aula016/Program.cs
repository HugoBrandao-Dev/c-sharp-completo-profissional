using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula016
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "Tobias de Oliveira";
            string msg = null;
            string mensagemComEscape = "Essa mensagem tem uma\nquabra de linha.";
            string msgComArroba = @"\u0041 será tratado como caracteres comuns, pq essa string inicia com @.";

            msg = "Uma lorem ipsum bem aqui ;)";

            Console.WriteLine(nome);
            Console.WriteLine(msg);
            Console.WriteLine(mensagemComEscape);
            Console.WriteLine(msgComArroba);
        }
    }
}
