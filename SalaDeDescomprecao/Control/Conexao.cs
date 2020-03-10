using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaDeDescomprecao.Control
{
    class Conexao
    {
        public static string conectar()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\FERNANDO.LROCHA\source\repos\Solução_SalaDeDescompressao\SalaDeDescomprecao\DatabaseSalaDeDescompressao.mdf;Integrated Security=True";
        }
    }
}
