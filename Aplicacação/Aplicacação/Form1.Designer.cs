namespace Aplicacação
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Close = new System.Windows.Forms.PictureBox();
            this.Game = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Game)).BeginInit();
            this.SuspendLayout();
            // 
            // Close
            // 
            this.Close.Image = global::Aplicacação.Properties.Resources.icons8_cross_mark_button_48;
            this.Close.Location = new System.Drawing.Point(742, 12);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(46, 50);
            this.Close.TabIndex = 0;
            this.Close.TabStop = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Game
            // 
            this.Game.Location = new System.Drawing.Point(134, 21);
            this.Game.Name = "Game";
            this.Game.Size = new System.Drawing.Size(542, 465);
            this.Game.TabIndex = 1;
            this.Game.TabStop = false;
            this.Game.Paint += new System.Windows.Forms.PaintEventHandler(this.Game_Paint);
            this.Game.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Game_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(800, 533);
            this.Controls.Add(this.Game);
            this.Controls.Add(this.Close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Game)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Close;
        private System.Windows.Forms.PictureBox Game;
    }
}

