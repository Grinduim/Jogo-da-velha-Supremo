using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacação
{
    public partial class PVL : Form
    {
        public byte[] hash = new byte[9];
        Bitmap bmp;
        Graphics g;
        public int jogador = 1;
        public PVL()
        {
            InitializeComponent();
            LimparJogo();
            bmp = new Bitmap(Game.Width, Game.Height);
            g = Graphics.FromImage(bmp);
        }

        private void Close_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void Game_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen myPen = new Pen(Color.Black, 4);               // faço as formas
            Brush myBrush = new SolidBrush(Color.Red);     // pinto as formas

            Point[] Linha1Vertical =
            {
                new Point((Game.Width/3), 0),
                new Point((Game.Width/3), Game.Height),
            };
            g.DrawLines(myPen, Linha1Vertical);


            Point[] Linha2Vertical =
            {
                new Point(Game.Width/3 * 2  , 0),
                new Point(Game.Width/3 * 2 , Game.Height),
            };
            g.DrawLines(myPen, Linha2Vertical);

            Point[] Linha1Horizontal =
            {
                new Point(0, Game.Height/3),
                new Point(Game.Width, Game.Height/3),
            };
            g.DrawLines(myPen, Linha1Horizontal);

            Point[] Linha2Horizontal =
           {
                new Point(0, Game.Height/3 * 2 ),
                new Point(Game.Width , Game.Height/3 * 2),
            };
            g.DrawLines(myPen, Linha2Horizontal);

        }

        private void Game_MouseClick(object sender, MouseEventArgs e)
        {
            var x = e.X;
            var y = e.Y;
            int pos = -1;


            #region Validação de onde clicou
            if (x < Game.Width / 3 && y < Game.Height / 3) // primeira linha primeira colunha
            {
                pos = 0;
            }// primeira linha segunda colunha
            else if (x > Game.Width / 3 && x <= Game.Width / 3 * 2 && y < Game.Height / 3)
            {
                pos = 1;
            }// primeira linha terceira colunha
            else if (x > Game.Width / 3 * 2 && y < Game.Height / 3)
            {
                pos = 2;
            }// segunda linha primeira colunha
            else if (x < Game.Width / 3 && y < Game.Height / 3 * 2 && y > Game.Height / 3)
            {
                pos = 3;
            }// segunda linha segunda colunha
            else if (x > Game.Width / 3 && x < Game.Width / 3 * 2 && y < Game.Height / 3 * 2 && y > Game.Height / 3)
            {
                pos = 4;
            }// segunda linha terceira colunha
            else if (x > Game.Width / 3 * 2 && y < Game.Height / 3 * 2 && y > Game.Height / 3)
            {
                pos = 5;
            }// terceira linha primeira colunha
            else if (x < Game.Width / 3 && y > Game.Height / 3 * 2)
            {
                pos = 6;
            }
            else if (x > Game.Width / 3 && x < Game.Width / 3 * 2 && y > Game.Height / 3 * 2)
            {
                pos = 7;
            }
            else if (x > Game.Width / 3 * 2 && y > Game.Height / 3 * 2)
            {
                pos = 8;
            }
            #endregion


            if (CasaDisponivel(pos) && pos != -1 && jogador == 1 )
            {
                hash[pos] = 1;
                jogador = FazerJogada(pos, jogador);

            }
            else
            {
                hash[pos] = 2;
                jogador = FazerJogada(pos, jogador);

            }

            int vencedor = VerificarGanhador();
            if (vencedor != 0)
            {
                MessageBox.Show($"O jogador {vencedor} ganho!");
            }

            if (DeuVelha())
            {
                MessageBox.Show("Jogo empatado! Deu velha!");
            }
        }


        public bool CasaDisponivel(int pos)
        {
            if (hash[pos] == 0)
                return true;
            MessageBox.Show("Casa ja selecionada");
            return false;
        }

        public void LimparJogo()
        {
            for (int i = 0; i < hash.Length; i++)
            {
                hash[i] = 0;
            }
        }

        public int FazerJogada(int pos, int jogador)
        {
            int y = pos / 3;
            int x = pos % 3;
            float px = x * Game.Width / 3;
            float py = y * Game.Height / 3;

            Image newImage;
            if (jogador == 1)
            {
                newImage = Properties.Resources.XGame;
                g.DrawImage(newImage, px, py, Game.Width / 3, Game.Height / 3);// tentar ajustar essa bosta aq
                Game.Image = bmp;
                return 2;
            }
            newImage = Properties.Resources.Circle1;
            g.DrawImage(newImage, px, py, Game.Width / 3, Game.Height / 3);// tentar ajustar essa bosta aq
            Game.Image = bmp;
            return 1;
        }

        public int VerificarGanhador()
        {
            int[][] possibilidades = { new int[]{ 0, 1, 2 }, new int[]{ 3, 4, 5 }, new int[] { 6, 7, 8 }, new int[] { 0, 3, 6 }, new int[] { 1, 4, 7 }, new int[] { 2, 5, 8 }, new int[] { 0, 4, 8 }, new int[] { 6, 4, 8 } };

            foreach (var item in possibilidades)
            {
                if(hash[item[0]] == hash[item[1]] && hash[item[2]] == hash[item[1]])
                {
                    MessageBox.Show(hash[item[0]].ToString());
                    return hash[item[0]];
                }
            }

            return 0;
        }

        public Boolean DeuVelha()
        {
            int sum = 0 ; 
            for(int i = 0; i < hash.Length; i++)
            {
                sum =+ hash[i];
            }

            if (sum == 13)
            {
                return true;
            }
            return false;
        }
    }
}
