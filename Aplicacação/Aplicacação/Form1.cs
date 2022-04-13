using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacação
{
    public partial class Form1 : Form
    {
        public byte[] hash = new byte[9];
        Bitmap bmp;
        Graphics g;
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
            Pen myPen = new Pen(Color.Black,4);               // faço as formas
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
            int pos  = -1;

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

            if (CasaDisponivel(pos) && pos != -1)
            {
                hash[pos] = 1;
                MessageBox.Show("Ea");
                FazerJogada(pos);
            }
        }


        public bool CasaDisponivel(int pos)
        {
            if (hash[pos] == 0)
                return true;
            return false;
        }

        public void LimparJogo()
        {
           for(int i = 0; i < hash.Length; i++)
           {
                hash[i] = 0;
           }
        }

        public void FazerJogada(int pos)
        {
            MessageBox.Show("Entrou");
            int y = pos / 3;
            int x = pos % 3;
            float px = x * Game.Width / 3;
            float py = y * Game.Height / 3;

            Image newImage = Properties.Resources.XGame;
            // Create Point for upper-left corner of image.
            Point ulCorner = new Point(100, 100);

            // Draw image to screen.
            g.DrawImage(newImage,px,py, Game.Width , Game.Height); // tentar ajustar essa bosta aq
            //Pen pen = new Pen(Color.Blue,8);
            //g.DrawLine(pen, px + 20, py +20, px + Game.Height / 3, py + Game.Height / 3 - 20);
            //g.DrawLine(pen, px + Game.Height / 3, py, px+20, py + Game.Height / 3 +20);
            MessageBox.Show("saiu");
            Game.Image = bmp;
        }
    }
}
