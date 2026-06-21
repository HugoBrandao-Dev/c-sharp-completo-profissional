using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula017
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Tipo var
            var produto = "Creme dental";
            var preco = 7.5;
            var haEstoque = true;

            haEstoque = false;
            #endregion

            Console.WriteLine(produto);
            Console.WriteLine(preco);
            Console.WriteLine(haEstoque);
        }
    }
}
