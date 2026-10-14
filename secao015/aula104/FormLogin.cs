using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula104
{
    public partial class FormLogin : Form
    {
        public static bool Cancelar = false;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string nome = iptUsuario.Text;
            string senha = iptSenha.Text;

            if (CadastroUsuarios.Login(nome, senha))
            {
                this.Close();
            } else
            {
                MessageBox.Show("Acesso Negado!");
                iptUsuario.Text = "";
                iptSenha.Text = "";
                iptUsuario.Focus();
                this.Close();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar = true; // Cancelou com o Cancelar do formário de Login
            Close();

        }
    }
}
