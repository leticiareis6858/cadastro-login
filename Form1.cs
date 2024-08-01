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
            Database db = new Database();
            db.CreateTables();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "")
            {
                MessageBox.Show("Por favor, informe o nome de usuário",
                     "Informação",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Information);
            }
            else
                if (txt_senha.Text == "")
            {
                MessageBox.Show("Por favor, informe uma senha",
                   "Informação",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            }
            else
            {
                Database db = new Database();
                string query = $"SELECT * FROM usuarios WHERE usuario = '{txt_usuario.Text}' AND senha = '{txt_senha.Text}'";
                DataTable result = db.ExecuteQuery(query);

                if (result.Rows.Count > 0)
                {
                    Form2 form2 = new Form2();
                    form2.txt_usuario.Text = txt_usuario.Text;

                    this.Hide();
                    form2.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválidos",
                        "Erro de autenticação",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
