using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula058
{
    internal class Metodos
    {
        // Métodos simples
        public void Apresentacao()
        {
            Console.WriteLine("=> SOMADOR <=");
        }
        public void Cumprimentar(string nome, short ano)
        {
            Console.WriteLine("\nOlá, seja bem vindo " + nome + ". Esse programa está rodando em " + ano + ".\n");
        }

        // Métodos com parâmetros
        public void Somar(int num1, int num2)
        {
            int soma = num1 + num2;
            Console.WriteLine(num1 + " + " + num2 + " = " + soma);
        }
    }
}
