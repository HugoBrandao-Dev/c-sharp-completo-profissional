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

            // Seta o Masculino como valor padrão para sexo
            rdMasculino.Checked = true;
        }

        private void listarCadastrados()
        {
            lsCadastrados.Items.Clear();

            foreach (Pessoa cadastro in pessoas)
            {
                // Adiciona o nome da pessoa na lista de cadastrados
                lsCadastrados.Items.Add(cadastro.Nome);
            }
        }

        private void btnCadAlt_Click(object sender, EventArgs e)
        {

            int index = -1; // Usado para fazer atualização, caso o usuário já exista
            char sexo;

            // Campo de Nome

            if (txtNome.Text == "")
            {

                MessageBox.Show("Prencha o campo nome.");
                txtNome.Focus();
                return;

            }

            // Campo de Telefone

            txtTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            if (txtTelefone.Text == "")
            {

                MessageBox.Show("Preencha o campo telefone");
                txtTelefone.Focus();
                return;

            }

            // Campo de Sexo

            if (rdMasculino.Checked)
            {
                sexo = 'M';
            } else if (rdFeminino.Checked)
            {
                sexo = 'F';
            } else
            {
                sexo = 'O';
            }

            Pessoa ps = new Pessoa();
            ps.Nome = txtNome.Text;
            ps.DataNascimento = txtDataNascimento.Text;
            ps.EstadoCivil = cbEstadoCivil.SelectedItem.ToString();
            ps.Telefone = txtTelefone.Text;
            ps.CasaPropria = cbCasa.Checked;
            ps.Veiculo = cbVeiculo.Checked;
            ps.Sexo = sexo;

            foreach (Pessoa p in pessoas)
            {
                if (p.Nome == ps.Nome)
                {
                    index = pessoas.IndexOf(p);
                    break;
                }
            }

            // Atualiza o cadastro se já existir um de mesmo nome.
            if (index != -1)
            {
                pessoas[index] = ps;

            // Cadastra um novo.
            } else
            {
                pessoas.Add(ps);
            }

            btnLimpar_Click(btnLimpar, EventArgs.Empty);

            listarCadastrados();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtDataNascimento.Text = "";
            txtTelefone.Text = "";
            cbEstadoCivil.SelectedIndex = 0;
            cbCasa.Checked = false;
            cbVeiculo.Checked = false;

            rdMasculino.Checked = true;
            rdFeminino.Checked = false;
            rdOutro.Checked = false;

            txtNome.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // Remove a pessoa selecionada com o mouse da lista de pessoas.
            pessoas.RemoveAt(lsCadastrados.SelectedIndex);

            listarCadastrados();

        }
    }
}
