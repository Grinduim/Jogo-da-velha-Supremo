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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //registrar no banco os dados inseridos, com as devidas validações 

            MessageBox.Show("Usuario cadastrado!");
            this.Hide();
            var login = new Login();
            login.Show();
        }
    }
}
