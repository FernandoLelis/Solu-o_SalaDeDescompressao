using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaDeDescomprecao.Model
{
    class Usuario
    {
        private static string cpf;
        private static string nome;
        private static string email;
        private static string celular;
        private static string senha;

        public static string Cpf { get => cpf; set => cpf = value; }
        public static string Nome { get => nome; set => nome = value; }
        public static string Email { get => email; set => email = value; }
        public static string Celular { get => celular; set => celular = value; }
        public static string Senha { get => senha; set => senha = value; }
    }
}
