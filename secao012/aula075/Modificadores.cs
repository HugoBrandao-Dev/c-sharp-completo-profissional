using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula075
{
    internal class Teste
    {
        private string nome;
        public string sobrenome;

        private void MetodoUm() { }

        public void Executar() { }
    }
    internal class Humano
    {
        // Disponível somente nesta classe
        protected string nome;

        // Disponível para essa classe e para seus herdeiros
        private string sobrenome;

        // Disponível para a compilação
        internal int idade;
    }

    internal class Homem : Humano
    {
        public void Metodo()
        {
            nome = "";
            idade = 0;
        }
    }
}
