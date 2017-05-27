using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV
{
    class Produto
    {
        //propriedades
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public double PrecoUnitario { get; set; }
        public int Qtd { get; set; }

        //contrutores
        public Produto()
        {
            //vazio
        }

        public Produto(int codigo, string descricao, double precoUnitario, int qtd)
        {
            this.Codigo = codigo;
            this.Descricao = descricao;
            this.PrecoUnitario = precoUnitario;
            this.Qtd = qtd;
        }

        public List<Produto> getProdutos()
        {
            List<Produto> listaProdutos = new List<Produto>();
            listaProdutos.Add(new Produto(1, "Mamão", 7.50,1));
            listaProdutos.Add(new Produto(2, "Pera", 10.20,1));
            listaProdutos.Add(new Produto(3,"Batata", 4.35,1));
            listaProdutos.Add(new Produto(4,"Cenoura", 6.10,1));
            listaProdutos.Add(new Produto(5,"Limão", 2.50,1));
            listaProdutos.Add(new Produto(6,"Alho", 4.30,1));
            listaProdutos.Add(new Produto(7,"Alface",3.10,1));
            listaProdutos.Add(new Produto(8,"Maça", 7.40,1));
            listaProdutos.Add(new Produto(9,"Acelga",6.10,1));
            listaProdutos.Add(new Produto(10,"Maracujá",8.60,1));

            return listaProdutos;
        }

        public Produto buscaPorCodigo(int codigo)
        {
            Produto produtoBusca = null;
            foreach (var produto in getProdutos())
            {
                
                if (produto.Codigo == codigo)
                {
                    produtoBusca = produto;
                    break;
                }
                
                
            }

            return produtoBusca;
        }

    }
}
