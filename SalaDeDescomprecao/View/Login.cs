using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalaDeDescomprecao.Model;
using SalaDeDescomprecao.Control;

namespace SalaDeDescomprecao.View
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void labelCpfLogin_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCpfLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
           
            Usuario.Cpf = textBoxCpfLogin.Text;
            Usuario.Senha = textBoxSenhaLogin.Text;

            this.Visible = false;
            ManipulaUsuario manipulaUsuario = new ManipulaUsuario();
            manipulaUsuario.loginUsuario();
            
        }

        private void labelRealizarCadastro_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadastrarUsuario cadastrarUsuario = new CadastrarUsuario();
            cadastrarUsuario.Closed += (s, args) => this.Close();
            cadastrarUsuario.ShowDialog();

            

            
        }

        private void labelSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
