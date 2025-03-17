using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoKenPo
{
    internal class Game
    {
        public static void LoadGame()
        {
            paths = new Dictionary<string, string>();
            string _ = "../../../images/", png = ".png";
            string[] imagens = {
                "papel", 
                "pedra", 
                "tesoura",
                "lagarto",
                "spock", 
            };

            foreach(string img in imagens)
                paths.Add(img, $"{_}{img}{png}");
        }

        public static Dictionary<string, string> paths = new();

        public static Image[] images =
        {
            Image.FromFile("../../../images/papel.png"),
            Image.FromFile("../../../images/pedra.png"),
            Image.FromFile("../../../images/tesoura.png"),
            Image.FromFile("../../../images/lagarto.png"),
            Image.FromFile("../../../images/spock.png")
        };

        public enum Resultado
        {
            Empatar, Ganhar, Perder
        }

        public Image ImagemJogador { get; private set; }
        public Image ImagemPC { get; private set; }
                
        private byte jogadaPC(string modoDeJogo)
        {
            try
            {
                if (modoDeJogo == "classico")
                {
                    int mil = DateTime.Now.Millisecond;

                    if (mil < 333)
                    {
                        return 0;
                    }
                    else if (mil > 333 && mil < 667)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
                else
                {
                    int mil = DateTime.Now.Millisecond;

                    if (mil < 200)
                    {
                        return 0;
                    }
                    else if (mil > 200 && mil < 400)
                    {
                        return 1;
                    }
                    else if (mil > 400 && mil < 600)
                    {
                        return 2;
                    }
                    else if (mil > 600 && mil < 800)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 5;
            }            
        }

        public Resultado jogar(byte jogador, string modoDeJogo)
        {            
            byte pc = jogadaPC(modoDeJogo);

            ImagemJogador = images[jogador];
            ImagemPC = images[pc];

            if (jogador == pc)
            {
                return Resultado.Empatar;
            }
            else if ((jogador == 2 && pc == 0) || (jogador == 0 && pc == 1) || (jogador == 1 && pc == 3) ||
                     (jogador == 3 && pc == 4) || (jogador == 4 && pc == 2) || (jogador == 2 && pc == 3) ||
                     (jogador == 3 && pc == 0) || (jogador == 0 && pc == 4) || (jogador == 4 && pc == 1) ||
                     (jogador == 1 && pc == 2))
            {
                return Resultado.Ganhar;
            }
            else
            {
                return Resultado.Perder;
            }
        }
    }
}
