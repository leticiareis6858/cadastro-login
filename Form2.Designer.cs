namespace meuPrimeiroProjeto
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.txt_bemvindo = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_sair = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_bemvindo
            // 
            this.txt_bemvindo.AutoSize = true;
            this.txt_bemvindo.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bemvindo.ForeColor = System.Drawing.Color.Black;
            this.txt_bemvindo.Location = new System.Drawing.Point(93, 43);
            this.txt_bemvindo.Name = "txt_bemvindo";
            this.txt_bemvindo.Size = new System.Drawing.Size(138, 21);
            this.txt_bemvindo.TabIndex = 1;
            this.txt_bemvindo.Text = "Bem vindo(a), ";
            this.txt_bemvindo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_usuario
            // 
            this.txt_usuario.AutoSize = true;
            this.txt_usuario.Font = new System.Drawing.Font("Rockwell", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.ForeColor = System.Drawing.Color.Brown;
            this.txt_usuario.Location = new System.Drawing.Point(225, 43);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(88, 26);
            this.txt_usuario.TabIndex = 2;
            this.txt_usuario.Text = "usuário";
            this.txt_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(84, 155);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(361, 224);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btn_sair
            // 
            this.btn_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.Location = new System.Drawing.Point(460, 388);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 23);
            this.btn_sair.TabIndex = 5;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.txt_bemvindo);
            this.panel1.Controls.Add(this.txt_usuario);
            this.panel1.Location = new System.Drawing.Point(51, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 100);
            this.panel1.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(538, 414);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Tela de abertura";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Label txt_bemvindo;
        public System.Windows.Forms.Label txt_usuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Panel panel1;
    }
}