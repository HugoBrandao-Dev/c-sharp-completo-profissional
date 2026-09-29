using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula085
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Size é uma propriedade da namespace System.Drawing, por isso é possivel instanciar aqui.
            Size tamanho = new Size();
            tamanho.Width = 800;
            tamanho.Height = 400;

            this.Text = "Janela";

            this.Size = tamanho;
            // OU this.Size = new Size(400, 200);
        }
    }
}
