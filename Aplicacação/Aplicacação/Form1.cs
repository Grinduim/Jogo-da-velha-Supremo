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
    public partial class Form1 : Form
    {
        public byte[] hash = new byte[9];
        Bitmap bmp;
        Graphics g;
        public int jogador;
        public Form1()
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
            jogador = 1;

        }

        private void Game_MouseClick(object sender, MouseEventArgs e)
        {
            var x = e.X;
            var y = e.Y;
            int pos = -1;

            if (x < Game.Width / 3 && y < Game.Height / 3) // primeira linha primeira colunha
            {
                MessageBox.Show($"Area 1");
                pos = 0;
            }// primeira linha segunda colunha
            else if (x > Game.Width / 3 && x <= Game.Width / 3 * 2 && y < Game.Height / 3)
            {
                MessageBox.Show("Area 2");
                pos = 1;
            }// primeira linha terceira colunha
            else if (x > Game.Width / 3 * 2 && y < Game.Height / 3)
            {
                MessageBox.Show("Area 3");
                pos = 2;
            }// segunda linha primeira colunha
            else if (x < Game.Width / 3 && y < Game.Height / 3 * 2 && y > Game.Height / 3)
            {
                MessageBox.Show("Area 4");
                pos = 3;
            }// segunda linha segunda colunha
            else if (x > Game.Width / 3 && x < Game.Width / 3 * 2 && y < Game.Height / 3 * 2 && y > Game.Height / 3)
            {
                pos = 4;
                MessageBox.Show("Area 5");
            }// segunda linha terceira colunha
            else if (x > Game.Width / 3 * 2 && y < Game.Height / 3 * 2 && y > Game.Height / 3)
            {
                MessageBox.Show("Area 6");
                pos = 5;
            }// terceira linha primeira colunha
            else if (x < Game.Width / 3 && y > Game.Height / 3 * 2)
            {
                MessageBox.Show("Area 7");
                pos = 6;
            }
            else if (x > Game.Width / 3 && x < Game.Width / 3 * 2 && y > Game.Height / 3 * 2)
            {
                MessageBox.Show("Area 8");
                pos = 7;
            }
            else if (x > Game.Width / 3 * 2 && y > Game.Height / 3 * 2)
            {
                MessageBox.Show("Area 9");
                pos = 8;
            }

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


            byte aa = VerificarGanhador();

            MessageBox.Show($"Jogador : {jogador}");
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

        public byte VerificarGanhador()
        {
            int[,] possibilidades = { { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 }, { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 }, { 0, 4, 8 }, { 6, 4, 8 } };

            for (int i = 0; i < possibilidades.Length / 3; i++)
            {
                if (hash[possibilidades[i, 0]] != 0 && hash[possibilidades[i, 0]] == hash[possibilidades[i, 1]] && hash[possibilidades[i, 0]] == hash[possibilidades[i, i]])
                {
                    return hash[possibilidades[i, 0]];
                }
            }
            return 0;
        }
    }
}
