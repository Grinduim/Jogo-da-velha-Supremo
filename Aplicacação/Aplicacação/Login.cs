using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net;
using Newtonsoft.Json;

namespace Aplicacação
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void btnEntrar_Click(object sender, EventArgs e)
        {
            using(var client = new HttpClient())
            {
                var path = $"https://localhost:44301/api/login/{txbLogin.Text}/{TxbSenha.Text}/";
                var response = await client.GetAsync(path);
                var content = await response.Content.ReadAsStringAsync();
                Usuario obj = JsonConvert.DeserializeObject<Usuario>(content);
                if(obj.Nick != null)
                {
                    this.Hide();
                    PVL form = new PVL();
                    form.Show();
                    txbLogin.Text = "";
                    TxbSenha.Text = "";
                    return;
                }
                MessageBox.Show("Senha ou email invalido");
                TxbSenha.Text = "";
                return;
                
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkCadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var cadastro = new Cadastro();
            cadastro.Show();

        }
    }
}
