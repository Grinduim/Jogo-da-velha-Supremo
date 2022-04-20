namespace Aplicacação
{
    partial class SelecaoGame
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
            this.btnLocal = new System.Windows.Forms.Label();
            this.BtnOnline = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Aplicacação.Properties.Resources.icons8_cross_mark_button_48;
            this.pictureBox1.Location = new System.Drawing.Point(143, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 41);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnLocal
            // 
            this.btnLocal.AutoSize = true;
            this.btnLocal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(233)))));
            this.btnLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocal.Location = new System.Drawing.Point(44, 100);
            this.btnLocal.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.btnLocal.Name = "btnLocal";
            this.btnLocal.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.btnLocal.Size = new System.Drawing.Size(119, 51);
            this.btnLocal.TabIndex = 13;
            this.btnLocal.Text = "Local";
            this.btnLocal.Click += new System.EventHandler(this.btnLocal_Click);
            // 
            // BtnOnline
            // 
            this.BtnOnline.AutoSize = true;
            this.BtnOnline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(233)))));
            this.BtnOnline.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOnline.Location = new System.Drawing.Point(41, 171);
            this.BtnOnline.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.BtnOnline.Name = "BtnOnline";
            this.BtnOnline.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.BtnOnline.Size = new System.Drawing.Size(122, 51);
            this.BtnOnline.TabIndex = 14;
            this.BtnOnline.Text = "Online";
            // 
            // SelecaoGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 250);
            this.Controls.Add(this.BtnOnline);
            this.Controls.Add(this.btnLocal);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelecaoGame";
            this.Text = "SelecaoGame";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label btnLocal;
        private System.Windows.Forms.Label BtnOnline;
    }
}