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
        public Form1()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Game_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen myPen = new Pen(Color.Black);               // faço as formas
            Brush myBrush =  new SolidBrush(Color.Red);     // pinto as formas
            
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

            g.FillRectangle(myBrush, new Rectangle(10, 0, 170, 152));
        }

        private void Game_MouseClick(object sender, MouseEventArgs e)
        {
            var x = e.X;
            var y = e.Y;
            if( x >= 5 && x <= 185 && y >= 0 && y <= 152)
            {
                MessageBox.Show("Aaa");
            }

        }
    }
}
