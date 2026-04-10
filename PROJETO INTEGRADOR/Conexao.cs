using MySql.Data.MySqlClient; // Importante: Adicione esta linha
using System;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace PROJETO_INTEGRADOR
{
    public class Conexao
    {
        // String ajustada com o nome exato do seu banco: dbprotegelar
        private static string strConn = "Server=localhost;Database=dbprotegelar;Uid=root;Pwd=;";

        public static MySqlConnection GetConexao()
        {
            return new MySqlConnection(strConn);
        }

        // Método para você usar no botão de Login ou Cadastro
        public static void Abrir(MySqlConnection conexao)
        {
            if (conexao.State == ConnectionState.Closed)
            {
                conexao.Open();
            }
        }

        public static void Fechar(MySqlConnection conexao)
        {
            if (conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }
        }

        internal MySqlConnection Conectar()
        {
            throw new NotImplementedException();
        }
    }
}
