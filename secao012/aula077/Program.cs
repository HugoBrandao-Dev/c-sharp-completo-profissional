using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula077
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaixaEletronico ce = new CaixaEletronico();
            ce.Usuario = "Tobias";
            ce.Sacar();
            ce.Depositar();
            ce.Saldo();
            ce.SolicitarEmprestimo();
        }
    }
}
