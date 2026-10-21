using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula113
{
    public partial class Form1 : Form
    {
        private List<string> nomes = new List<string>();

        private void renderizarLista()
        {
            lsNomes.Items.Clear();

            foreach (string n in nomes)
            {
                this.lsNomes.Items.Add(n);
            }

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            string nome = iptNome.Text;

            if (!string.IsNullOrEmpty(nome))
            {
                nomes.Add(nome);
                iptNome.Text = "";
                iptNome.Focus();
                renderizarLista();
                } else
            {
                MessageBox.Show("Informe um nome!");
            }

        }

        private void btnTemValor_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(iptNome.Text))
            {

                bool hasName = this.nomes.Contains(iptNome.Text);
                int posicao = this.nomes.IndexOf(iptNome.Text);

                txtResult.Text = hasName ? ("Sim: " + posicao) : "Não";
                
            } else
            {

                MessageBox.Show("Informe o nome!");

            }

        }

        private void btnQtdItens_Click(object sender, EventArgs e)
        {

            int qtdItens = this.nomes.Count;

            txtResult.Text = qtdItens.ToString();

        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {

            this.nomes.Sort();
            renderizarLista();

        }

        private void btnAddEm_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(iptNome.Text))
            {
                MessageBox.Show("Informe o nome!");
            } else if (string.IsNullOrEmpty(iptIndice.Text))
            {
                MessageBox.Show("Informe o índice!");
            } else
            {
                string nome = iptNome.Text;
                int indice = int.Parse(iptIndice.Text);

                this.nomes.Insert(indice, nome);
                renderizarLista();
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void btnRemoverEm_Click(object sender, EventArgs e)
        {

            // Informou o índice;
            if (!string.IsNullOrEmpty(iptIndice.Text))
            {

                int indice = int.Parse(iptIndice.Text);

                // O índice está dentro do tamanho da lista.
                bool isDentroIntervalo = indice < (this.nomes.Count - 1);

                if (isDentroIntervalo)
                {
                    nomes.RemoveAt(indice);
                    renderizarLista();
                }

            } else
            {
                MessageBox.Show("Informe o índice!");
            }

        }
    }
}
