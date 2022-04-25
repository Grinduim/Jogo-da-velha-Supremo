namespace Aplicacação
{
    partial class Cadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.TxbSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txNick = new System.Windows.Forms.TextBox();
            this.Nick = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Aplicacação.Properties.Resources.icons8_cross_mark_button_48;
            this.pictureBox1.Location = new System.Drawing.Point(211, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 41);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 136);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "E-mail:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txbEmail
            // 
            this.txbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmail.Location = new System.Drawing.Point(95, 132);
            this.txbEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(105, 26);
            this.txbEmail.TabIndex = 1;
            // 
            // TxbSenha
            // 
            this.TxbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbSenha.Location = new System.Drawing.Point(95, 215);
            this.TxbSenha.Margin = new System.Windows.Forms.Padding(2);
            this.TxbSenha.Name = "TxbSenha";
            this.TxbSenha.Size = new System.Drawing.Size(105, 26);
            this.TxbSenha.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 219);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Senha:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.AutoSize = true;
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(233)))));
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadastrar.Location = new System.Drawing.Point(88, 294);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.btnCadastrar.Size = new System.Drawing.Size(100, 37);
            this.btnCadastrar.TabIndex = 17;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(87, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.label4.Size = new System.Drawing.Size(114, 44);
            this.label4.TabIndex = 18;
            this.label4.Text = "Cadastro";
            // 
            // txNick
            // 
            this.txNick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNick.Location = new System.Drawing.Point(96, 179);
            this.txNick.Margin = new System.Windows.Forms.Padding(2);
            this.txNick.Name = "txNick";
            this.txNick.Size = new System.Drawing.Size(105, 26);
            this.txNick.TabIndex = 19;
            // 
            // Nick
            // 
            this.Nick.AutoSize = true;
            this.Nick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nick.Location = new System.Drawing.Point(23, 185);
            this.Nick.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Nick.Name = "Nick";
            this.Nick.Size = new System.Drawing.Size(43, 20);
            this.Nick.TabIndex = 20;
            this.Nick.Text = "Nick:";
            this.Nick.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nick.Click += new System.EventHandler(this.label5_Click);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 377);
            this.Controls.Add(this.Nick);
            this.Controls.Add(this.txNick);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.TxbSenha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox TxbSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label btnCadastrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txNick;
        private System.Windows.Forms.Label Nick;
    }
}