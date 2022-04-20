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
    public partial class SelecaoGame : Form
    {
        public SelecaoGame()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLocal_Click(object sender, EventArgs e)
        {
            this.Hide();
            PVL pvl =  new PVL();
            pvl.Show();
        }
    }
}
