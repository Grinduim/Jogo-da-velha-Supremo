using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
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
            Application.Exit();
            
        }

        private async void btnCadastrar_Click(object sender, EventArgs e)
        {
            //registrar no banco os dados inseridos, com as devidas validações 

           using(var client =  new HttpClient())
            {
                var path = $"https://localhost:44301/api/cadastro/{txbEmail.Text}/{TxbSenha.Text}/{txNick.Text}";
                Usuario usuario =  new Usuario();
                usuario.email = txbEmail.Text;
                usuario.Nick = txNick.Text;
                usuario.senha = TxbSenha.ToString();
                string json = JsonConvert.SerializeObject(usuario);
                StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8,"application/json");
                var response = await client.PostAsync(path, httpContent);
                if (response.IsSuccessStatusCode)
                {
                    var str = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(str);
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
