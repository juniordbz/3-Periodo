using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Projeto_CRUD.Util;

namespace Projeto_CRUD.Model
{   
    class Fornecedor : Object
    {
        public int id_forn { get; set; }
        public string fornecedor { get; set; }

        public Fornecedor()
        {

        }

        public Fornecedor(int id_forn, string nome) {
            this.id_forn = id_forn;
            this.fornecedor = fornecedor;
        }
        public List<Fornecedor> listar()
        {
            List<Fornecedor> lista = new List<Fornecedor>();
            NpgsqlConnection conexao = null;

            try
            {

                conexao = Conectadb.getConexao();
                string sql = "select * from fornecedor";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);

                //exe a consulta e acumula o resultado em uma tabela virtual
                NpgsqlDataReader dr = cmd.ExecuteReader();

                //percorre todas as linhas e monta uma lista
                while (dr.Read())
                {
                    Fornecedor forn = new Fornecedor();
                    forn.id_forn = Convert.ToInt16(dr["id_forn"]);
                    forn.fornecedor = dr["fornecedor"].ToString();

                    //add o objeto na lista
                    lista.Add(forn);
                }   
            }

            catch (Exception ex)
            {
                //  throw new Exception(ex.Message);
            }
            finally
            {
                if (conexao != null)
                {
                    conexao.Close();
                }
            }
            return lista;
        }
        public override string ToString()
        {
            return this.fornecedor;
        }

      
        //NpgsqlConnection cnx = new NpgsqlConnection("CONNECTIONSTRING");
        //string comando = "insert in to produto (forn_pkey) values ("'+fornecedor+'")";

          
        
        
    }
}
