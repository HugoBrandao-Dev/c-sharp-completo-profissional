using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula061
{
    internal class Sobrecarga
    {
        #region Formas de Cumprimentar
        public void Cumprimentar()
        {
            Console.WriteLine("Olá, seja bem vindo!!!");
        }

        // Não dá conflito, por causa da assinatura (parâmetros diferentes).
        public void Cumprimentar(string nome)
        {
            Console.WriteLine("Olá " + nome + ", seja bem vindo!!");
        }

        public void Cumprimentar(string nome, int hora)
        {
            string msg;

            if (hora < 12)
            {
                msg = "Bom dia";
            } else if (hora < 18)
            {
                msg = "Boa tarde";
            } else
            {
                msg = "Boa noite";
            }

            msg += ", " + nome + ". Seja bem vindo!!!";

            Console.WriteLine(msg);
        }
        #endregion

        #region Formas de Comparar
        public bool Comparar(int num1, int num2)
        {
            return num1 == num2;
        }

        public bool Comparar(string txt1, string txt2)
        {
            return txt1 == txt2;
        }
        #endregion
    }
}
