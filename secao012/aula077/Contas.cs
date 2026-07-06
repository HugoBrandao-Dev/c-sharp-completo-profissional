using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula077
{
    internal class CaixaEletronico : IConta
    {
        public string Usuario { get; set; }

        public void Depositar()
        {
            Console.WriteLine("Depositando...");
        }

        public void Sacar()
        {
            Console.WriteLine("Sacando...");
        }

        public void Saldo()
        {
            Console.WriteLine(Usuario + ", seu saldo é...?");
        }

        public void SolicitarEmprestimo()
        {
            Console.WriteLine("Ta precisando...");
        }
    }
    interface IConta
    {
        string Usuario { get; set; }
        void Depositar();
        void Sacar();
        void Saldo();
    }
}
