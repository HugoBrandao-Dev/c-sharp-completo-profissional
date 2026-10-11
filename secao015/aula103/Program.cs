using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula103
{
    internal class Program
    {
        static void Main(string[] args)
        {

            decimal preco = 16.87m;
            string produto = "cachorro-quente";
            DateTime dataPreco = DateTime.Now;

            // Usando o String.Format para juntar valores de variáveis.
            string resultFormat = String.Format("O preço do {0} no dia {2:d} é de {1:C2}", produto, preco, dataPreco);
            string resultFormatDataCompleta = String.Format("O preço do {0} no dia {2:D} é de {1:C2}", produto, preco, dataPreco);

            // Usando cifrão
            string resultCifrao = $"O preço do {produto} no dia {dataPreco:d} é de {preco:C2}";
            string resultHora = $"Mas às {dataPreco:t} talvez esse preço tenha mudado para {(preco + 1):C}";
            string resultCifraoHoraCompleta = $"Mas às {dataPreco:T} talvez esse preço tenha mudado para {(preco + 1):C}";

            Console.WriteLine(resultFormat);
            Console.WriteLine(resultFormatDataCompleta);
            Console.WriteLine(resultCifrao);
            Console.WriteLine(resultHora);
            Console.WriteLine(resultCifraoHoraCompleta);

            Console.ReadKey();

        }
    }
}
