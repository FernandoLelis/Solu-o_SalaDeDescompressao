using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using SalaDeDescomprecao.Model;
using SalaDeDescomprecao.View;

namespace SalaDeDescomprecao.Control
{
    class ManipulaUsuario
    {
        public void cadastraUsuario()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pCadastrarUsuario", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@nome", Usuario.Nome);
                cmd.Parameters.AddWithValue("@cpf", Usuario.Cpf);
                cmd.Parameters.AddWithValue("@email", Usuario.Email);
                cmd.Parameters.AddWithValue("@celular", Usuario.Celular);
                cmd.Parameters.AddWithValue("@senha", Usuario.Senha);

                cn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cadastro realizado com sucesso.");
            }
            catch (Exception)
            {

                throw;
            }
        }


        public void alterarUsuarios()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pAlterarUsuario", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@cpf", Usuario.Cpf);
            cn.Open();
            var dr = cmd.ExecuteReader();
            
                Usuario.Cpf = dr["CPF"].ToString();
                Usuario.Nome = dr["Nome"].ToString();
                Usuario.Email = dr["Email"].ToString();
                Usuario.Celular = dr["Celular"].ToString();
                Usuario.Senha = dr["Senha"].ToString();



            try
            {
                cmd.Parameters.AddWithValue("@cpf", Usuario.Cpf);
                cmd.Parameters.AddWithValue("@nome", Usuario.Nome);
                cmd.Parameters.AddWithValue("@email", Usuario.Email);
                cmd.Parameters.AddWithValue("@celular", Usuario.Celular);
                cmd.Parameters.AddWithValue("@Senha", Usuario.Senha);

                cn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Dados Alterados com Sucesso!");

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void loginUsuario()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pLoginUsuario", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            
           
            cmd.Parameters.AddWithValue("@cpf", Usuario.Cpf);
            cmd.Parameters.AddWithValue("@senha", Usuario.Senha);

            cn.Open();
            int i = (int) cmd.ExecuteScalar();

            if (i > 0)
            {
                TelaPrincipal telaPrincipal = new TelaPrincipal();
                telaPrincipal.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuário ou Senha Incorreto");
            }
           
        }
    }
}
