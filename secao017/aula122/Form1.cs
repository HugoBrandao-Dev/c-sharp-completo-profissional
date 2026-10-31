using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula122
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StartGame(int opcao)
        {

            txtResult.Visible = false;
            Game jogo = new Game();

            switch(jogo.Jogar(opcao))
            {
                case Game.Resultado.Ganhar:
                    picResult.BackgroundImage = Image.FromFile("imagens/Ganhar.png");
                    goto default;
                case Game.Resultado.Perder:
                    picResult.BackgroundImage = Image.FromFile("imagens/Perder.png");
                    goto default;
                case Game.Resultado.Empatar:
                    picResult.BackgroundImage = Image.FromFile("imagens/Empatar.png");
                    goto default;
                default:
                    picJogador.Image = jogo.imgJogadaJogador;
                    picPC.Image = jogo.imgJogadaPC;
                    break;
            }

        }

        private void btnPedra_Click(object sender, EventArgs e)
        {
            StartGame(0);
        }

        private void btnPapel_Click(object sender, EventArgs e)
        {
            StartGame(1);
        }

        private void btnTesoura_Click(object sender, EventArgs e)
        {
            StartGame(2);
        }
    }
}
