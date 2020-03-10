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
    public partial class AlterarDadosUsuario : Form
    {
        public AlterarDadosUsuario()
        {
            InitializeComponent();           
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
           
            Usuario.Cpf = textBoxAlterarCpf.Text;
            Usuario.Nome = textBoxAlterarNome.Text;
            Usuario.Email = textBoxAlterarEmail.Text;
            Usuario.Celular = textBoxAlterarCelular.Text;
            Usuario.Senha = textBoxAlterarSenha.Text;

            ManipulaUsuario manipulaUsuario = new ManipulaUsuario();
            manipulaUsuario.alterarUsuarios();

        }
    }
}
