using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Projeto_CRUD.Util;

namespace Projeto_CRUD.Model
{
    class Produtos
    {
        public Fornecedor fornecedor { get; set; }
        public int id_produto { get; set; }
        public string produto { get; set; }
        public int qtd { get; set; }
        public double valor_unit { get; set; }
    
        public Produtos() {

        }

        public Produtos(int id_produto, string produto, int qtd, double valor_unit)
        {
            this.id_produto = id_produto;
            this.produto = produto;
            this.qtd = qtd;
            this.valor_unit = valor_unit;
        }

        public void cad_Prod()
        {
            NpgsqlConnection conexao = null;
            try
            {
                conexao = Conectadb.getConexao(); 

                string sql = "insert into produto (produto, quantidade, valor_unit) values (@produto, @quantidade, @valor_unit)";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                cmd.Parameters.Add(new NpgsqlParameter("@produto", this.produto));
                cmd.Parameters.Add(new NpgsqlParameter("@quantidade", this.qtd));
                cmd.Parameters.Add(new NpgsqlParameter("@valor_unit", this.valor_unit));
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                if (conexao != null)
                {
                    conexao.Close();
                }

            }
        }


    }
}
