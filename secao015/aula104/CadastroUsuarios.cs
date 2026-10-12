using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula104
{
    internal static class CadastroUsuarios
    {

        private static Usuario[] usuarios =
        {
            new Usuario() { Nome = "Tobias", Senha = "tobias123" },
            new Usuario() { Nome = "Doralice", Senha = "dora321" }
        };

        private static Usuario _usuarioLogado = null;

        public static Usuario UsuarioLogado
        {
            get { return _usuarioLogado; }
            private set { _usuarioLogado = value; }
        }

        public static bool Login(string nome, string senha)
        {
            foreach (Usuario u in usuarios)
            {

                // Verifica o nome
                if (u.Nome.Equals(nome) && u.Senha.Equals(senha))
                {
                    // Loga o usuario entrado
                    UsuarioLogado = u;
                    return true;
                }
            }

            return false;
        }
    }
}
