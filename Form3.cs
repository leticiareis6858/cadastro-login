using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace meuPrimeiroProjeto
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btn_criar_Click(object sender, EventArgs e)
        {
            if(txt_usuario.Text=="")
            {
                MessageBox.Show("Por favor, informe o nome de usuário",
                        "Informação",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }
            else
                if(txt_senha.Text=="")
            {
                MessageBox.Show("Por favor, informe uma senha",
                    "Informação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Usuário criado com sucesso!",
                    "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form1 form1 = new Form1();

                this.Hide(); 
                form1.ShowDialog();
                this.Close(); 
            }
        }
    }
}
