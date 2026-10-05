using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula094
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {

            string texto = txtTexto.Text;
            string busca = iptBusca.Text;
            string resultBusca = "";

            int numero = 54;

            if (texto.Contains(busca))
            {

                resultBusca = "O texto contém a palavra procurada!";

            } else
            {
                resultBusca = "A palavra não foi encontrada.";
            }

            txtResult.Text = resultBusca;

            // Não funciona por só aceitar string
            // txtResult.Text = numero;

        }
    }
}
