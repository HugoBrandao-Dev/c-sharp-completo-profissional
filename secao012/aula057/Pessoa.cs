using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula057
{
    internal class Pessoa
    {
        // Atributos / Campos
        public string nome;
        public string email;
        public string cpf;

        // Métodos simples
        public void Cumprimentar()
        {
            Console.WriteLine("Olá, tudo bem " + nome + "?");
        }
    }
}
