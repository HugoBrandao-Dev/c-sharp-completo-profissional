using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula083
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int qtdItens = lsEmails.Items.Count;
            int maxItens = 5;

            // Permite adicionar somente 5 itens.
            if (qtdItens < maxItens)
            {
                // Pesquisei, no google, como adicionar um item a uma lista.
                lsEmails.Items.Add((qtdItens + 1) + " - " + iptEmail.Text);

                lbQtdRestantes.Text = (maxItens - qtdItens - 1).ToString();
            }
        }
    }
}
