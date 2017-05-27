using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;


namespace Projeto_CRUD.Util
{
    class Conectadb
    {
        //dados de conexao
        private static string serverName = "localhost";
        private static string port = "5433";
        private static string username = "postgres";
        private static string password = "postgres";
        private static string dataBaseName = "Projeto_CRUD";

        public static NpgsqlConnection getConexao()
        {
            try
            {
                string stgConexao = String.Format("Server={0};Port={1};User id={2};Password={3};Database={4};",
                    serverName, port, username, password, dataBaseName);

                NpgsqlConnection conexao = new NpgsqlConnection(stgConexao);

                conexao.Open();

                return conexao;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
