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
    public partial class TelaPrincipal : Form
    {
        
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void alterarDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlterarDadosUsuario alterarDadosUsuario = new AlterarDadosUsuario();
            alterarDadosUsuario.ShowDialog();
        }

        private void novaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FazerReserva fazerReserva = new FazerReserva();
            fazerReserva.ShowDialog();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarUsuario cadastrarUsuario = new CadastrarUsuario();
            cadastrarUsuario.ShowDialog();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
        }
    }
}
