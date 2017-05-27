using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV
{
    public partial class Form1 : Form
    {
        //declara e instancia um objeto produto
        Produto produto = new Produto();

        //declaração lista de obj da classe produto
        List<Produto> lista = new List<Produto>();

        public Form1()
        {
            InitializeComponent();
        }

        //evento
        private void txtCodigo_Leave(object sender, EventArgs e)
        {

            //recupera o código
            int codigo = int.Parse(txtCodigo.Text);

            //busca por codigo
            Produto produtoBusca = produto.buscaPorCodigo(codigo);

            //verifica se foi encontrado
            if (produtoBusca != null)
            {
                lbProduto.Text = produtoBusca.Descricao;
                txtPreco.Text = produtoBusca.PrecoUnitario.ToString();
                txtQtd.Text = Convert.ToString(produtoBusca.Qtd);
            }

            //exibe os produtos 

        }

        private void btIncluir_Click(object sender, EventArgs e)
        {
            //recupera os valores dos campos de texto e atribui ao obj
            Produto p = new Produto();

            p.Descricao = lbProduto.Text;
            p.Codigo = int.Parse(txtCodigo.Text);
            p.Qtd = int.Parse(txtQtd.Text);
            p.PrecoUnitario = double.Parse(txtPreco.Text);
            
            lista.Add(p);

            PreencherDGV();

            limparCampos();

            SomaDGV();
            
        }

        private void PreencherDGV()
        {
            //limpa os valores do vetor da DGV antes de inserir os novos.
            dgvProdutos.Rows.Clear();

            for (int i = 0; i < lista.Count; i++)
            {
                string[] nova_linha = new string[]
                {
                    lista[i].Descricao,
                    lista[i].Codigo.ToString(),
                    lista[i].PrecoUnitario.ToString(),
                    lista[i].Qtd.ToString()
                };
                dgvProdutos.Rows.Add(nova_linha);
            }
            
        }

        private void limparCampos()
        {
            txtCodigo.Clear();
            lbProduto.Text = "";
            txtPreco.Clear();
            txtQtd.Clear();
        }

        private void btFinalizar_Click(object sender, EventArgs e)
        {
            txtTroco.Text = Convert.ToString(Convert.ToDouble(txtValorRecebido.Text) - Convert.ToDouble(txtTotal.Text));

        }

        //metodo de acumular coluna da DGV
        private void SomaDGV()
        {
            double soma = 0;
            foreach (DataGridViewRow row in dgvProdutos.Rows)
            {
                soma += Convert.ToDouble(row.Cells["clPreco"].Value)* Convert.ToDouble(row.Cells["clQtd"].Value);

           
            }
            txtTotal.Text = soma.ToString();
        }

        private void btRemover_Click(object sender, EventArgs e)
        {

                //recupera o indice selecionado
                int indiceLinha = dgvProdutos.CurrentRow.Index;

                txtTotal.Text = Convert.ToString(Convert.ToDouble(txtTotal.Text) -(Convert.ToDouble(dgvProdutos.CurrentRow.Index)* Convert.ToDouble(txtQtd.Text)));

                //remove da lista
                lista.RemoveAt(indiceLinha);

                //nula referencia da Grid
                dgvProdutos.DataSource = null;

                PreencherDGV();

                //limpa campos
                limparCampos();
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dgvProdutos.CurrentRow.Cells[0].Value.ToString();
            lbProduto.Text = dgvProdutos.CurrentRow.Cells[1].Value.ToString();
            txtPreco.Text = dgvProdutos.CurrentRow.Cells[2].Value.ToString();
            txtQtd.Text = dgvProdutos.CurrentRow.Cells[3].Value.ToString();
        }
       
    }
}
