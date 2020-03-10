using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalaDeDescomprecao.Control;
using SalaDeDescomprecao.Model;


namespace SalaDeDescomprecao.View
{
    public partial class CadastrarUsuario : Form
    {
        public CadastrarUsuario()
        {
            InitializeComponent();
        }

        private void labelNome_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCpf_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            Usuario.Nome = textBoxNome.Text;
            Usuario.Cpf = textBoxCpf.Text;
            Usuario.Email = textBoxEmail.Text;
            Usuario.Celular = textBoxCelular.Text;
            Usuario.Senha = textBoxSenha.Text;

            ManipulaUsuario manipulaUsuario = new ManipulaUsuario();
            manipulaUsuario.cadastraUsuario();

            textBoxNome.Text = "";
            textBoxCpf.Text = "";
            textBoxEmail.Text = "";
            textBoxCelular.Text = "";
            textBoxSenha.Text = "";

            this.Hide();
            Login login = new Login();
            login.Closed += (s, args) => this.Close();
            login.ShowDialog();

        }
    }
}
