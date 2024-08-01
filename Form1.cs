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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            if((txt_usuario.Text=="")|| (txt_usuario.Text !="admin"))
            {
                MessageBox.Show("Usuário inválido",
                    "Campo obrigatório",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                if((txt_senha.Text=="") || (txt_senha.Text!="admin"))
            {
                MessageBox.Show("Senha inválida",
                    "Campo obrigatório",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Form2 form2 = new Form2();
                form2.txt_usuario.Text = txt_usuario.Text;

                this.Hide();
                form2.ShowDialog();
                this.Close();
            }
        }

        private void link_esqueci_senhaLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 form4 = new Form4();

            this.Hide();
            form4.ShowDialog();
            this.Close();
        }

        private void link_criar_usuarioLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 form3 = new Form3();

            this.Hide();
            form3.ShowDialog();
            this.Close();
        }
    }
}
