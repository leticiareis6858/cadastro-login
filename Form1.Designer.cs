namespace meuPrimeiroProjeto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.link_criar_usuario = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.link_esqueci_senha = new System.Windows.Forms.LinkLabel();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Teal;
            this.groupBox1.Controls.Add(this.link_criar_usuario);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.link_esqueci_senha);
            this.groupBox1.Controls.Add(this.txt_senha);
            this.groupBox1.Controls.Add(this.btn_entrar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_usuario);
            this.groupBox1.Location = new System.Drawing.Point(28, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 223);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // link_criar_usuario
            // 
            this.link_criar_usuario.AutoSize = true;
            this.link_criar_usuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.link_criar_usuario.Location = new System.Drawing.Point(125, 196);
            this.link_criar_usuario.Name = "link_criar_usuario";
            this.link_criar_usuario.Size = new System.Drawing.Size(92, 13);
            this.link_criar_usuario.TabIndex = 11;
            this.link_criar_usuario.TabStop = true;
            this.link_criar_usuario.Text = "Criar novo usuário";
            this.link_criar_usuario.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_criar_usuarioLinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(209, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuário";
            // 
            // link_esqueci_senha
            // 
            this.link_esqueci_senha.AutoSize = true;
            this.link_esqueci_senha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.link_esqueci_senha.Location = new System.Drawing.Point(12, 114);
            this.link_esqueci_senha.Name = "link_esqueci_senha";
            this.link_esqueci_senha.Size = new System.Drawing.Size(86, 13);
            this.link_esqueci_senha.TabIndex = 9;
            this.link_esqueci_senha.TabStop = true;
            this.link_esqueci_senha.Text = "Esqueci a senha";
            this.link_esqueci_senha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_esqueci_senhaLinkClicked);
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(14, 91);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(94, 20);
            this.txt_senha.TabIndex = 8;
            // 
            // btn_entrar
            // 
            this.btn_entrar.BackColor = System.Drawing.Color.IndianRed;
            this.btn_entrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_entrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_entrar.Location = new System.Drawing.Point(125, 156);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(92, 37);
            this.btn_entrar.TabIndex = 4;
            this.btn_entrar.Text = "ENTRAR";
            this.btn_entrar.UseVisualStyleBackColor = false;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(14, 39);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(94, 20);
            this.txt_usuario.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(406, 264);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Login";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Button btn_entrar;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel link_esqueci_senha;
        private System.Windows.Forms.LinkLabel link_criar_usuario;
    }
}
