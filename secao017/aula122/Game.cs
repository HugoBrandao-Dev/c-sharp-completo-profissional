using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula122
{
    internal class Game
    {

        public enum Resultado
        {
            Ganhar, Perder, Empatar
        }
        
        public static Image[] imagens =
        {
            Image.FromFile("imagens/Pedra.png"),
            Image.FromFile("imagens/Papel.png"),
            Image.FromFile("imagens/Tesoura.png"),
        };

        public Image imgJogadaPC { get; private set; }
        public Image imgJogadaJogador { get; private set; }

        private int JogadaPC()
        {

            int miliseg = DateTime.Now.Millisecond;
            if (miliseg < 333)
            {

                return 0;

            } else if (miliseg >= 333 && miliseg < 667)
            {

                return 1;

            } else
            {

                return 2;

            }

        }

        public Resultado Jogar(int jogador)
        {
            int pc = JogadaPC();

            Image ImgJogador = imagens[jogador];
            Image ImgPC = imagens[pc];

            if (jogador == pc)
            {

                return Resultado.Empatar;

                // 0 - Pedra
                // 1 - Papel
                // 2 - Tesoura
            } else if ((jogador == 0 && pc == 1) || (jogador == 1 && pc == 2) || (jogador == 2 && pc == 0))
            {
                return Resultado.Perder;
            } else
            {
                return Resultado.Ganhar;
            }

        }



    }
}
