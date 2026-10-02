using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula089
{
    public partial class formCadastro : Form
    {
        List<Pessoa> pessoas;

        string[] valoresEstadoCivil = { "Casada", "Solteira", "Viúva", "Separada" };

        public formCadastro()
        {
            InitializeComponent();

            pessoas = new List<Pessoa>();

            // Seta os valores padrão para o ComboBox Estado Civil
            foreach (string estado in valoresEstadoCivil)
            {
                cbEstadoCivil.Items.Add(estado);
            }

            // O primeiro item do ComboBox será o padrão.
            cbEstadoCivil.SelectedIndex = 0;
        }

        private void listarCadastrados()
        {
            lsCadastrados.Items.Clear();

            foreach (Pessoa cadastro in pessoas)
            {

                // Adiciona o nome da pessoa a lista de cadastrados
                lsCadastrados.Items.Add(cadastro.Nome);
            }
        }
    }
}
