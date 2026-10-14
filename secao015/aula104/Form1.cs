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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

            FormLogin fl = new FormLogin();

            while (CadastroUsuarios.UsuarioLogado == null)
            {

                this.Visible = false;
                fl.ShowDialog();

                // Cancelou pelo botão "Cancelar"
                if (FormLogin.Cancelar)
                {
                    Application.Exit();
                    return;
                }
                
            }

            txtInicio.Text = "Bem Vindo(a) \n" + CadastroUsuarios.UsuarioLogado.Nome;
            Visible = true;

        }
    }
}
