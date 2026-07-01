using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula062
{
    internal class Acessar
    {
        string senha = "asdf1234";

        public bool Login(string senha)
        {
            return senha == this.senha;
        }
    }
}
