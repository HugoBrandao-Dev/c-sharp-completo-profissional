using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula096
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string nome = "Tobias de Oliveira";
            short aPartirDe = 4;
            short dentroDe = 5;

            Console.WriteLine("Nome: " + nome);

            // Busca o primeira caracter
            Console.WriteLine("\nPosição da letra \'o\': " + nome.IndexOf('o'));
            Console.WriteLine("Posição de \'live\': " + nome.IndexOf("live"));

            // Posição a partir de ponto de início [
            Console.WriteLine("\nA partir da " + aPartirDe + " posição, a letra \'i\' esta em: " + nome.IndexOf('i', aPartirDe));
            Console.WriteLine("\nA partir da " + aPartirDe + " dentro de " + dentroDe + " \'vei\' está em " + nome.IndexOf("vei", aPartirDe, dentroDe)); // retorna -1 (não encontra)

            // Busca o último caracter
            Console.WriteLine("\nPosição da letra \'i\': " + nome.LastIndexOf('i'));
            Console.WriteLine("Posição de \'vei\': " + nome.LastIndexOf("vei"));

            Console.ReadKey();

        }
    }
}
