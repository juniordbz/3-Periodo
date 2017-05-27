using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova
{
    public partial class Locadora : Form
    {

        //declarar e instanciar um obj de veiculos
        Veiculos veiculos = new Veiculos();

        //declaração lista de obj da classe produto
        List<Veiculos> lista = new List<Veiculos>();

        //declarar e instanciar um obj de cliente
        Cliente clientes = new Cliente();

        //declaração lista de obj da classe cliente
        List<Cliente> listacli = new List<Cliente>();

        public Locadora()
        {
            InitializeComponent();
        }

        private void tbCodigo_Leave(object sender, EventArgs e)
        {
            //recupera o codigo
            int cod = Convert.ToInt16(tbCodigo.Text);

            //busca o produto pelo codigo
            Veiculos VeiculoBusca = veiculos.BuscaCod(cod);

            //verifica se o veiculo foi encontrado
            if (VeiculoBusca!= null)
            {
                lbdescicao.Text = VeiculoBusca.modelo;
            }
            
        }

        //preencher DGV
        public void PreencherDGV()
        {
            //limpa os valores do vetor da DGV antes de inserir os novos.
            dgvVeiculo.Rows.Clear();

            for (int i = 0; i < lista.Count; i++)
            {
                string[] novaLinha = new string[]
                {
                    lista[i].cod.ToString(),
                    lista[i].marca,
                    lista[i].modelo,
                    lista[i].valorAluguel.ToString()
                };
                dgvVeiculo.Rows.Add(novaLinha);
            }

        }

        private void btIncluir_Click(object sender, EventArgs e)
        {
            
            //recupera os valores dos campos de texto e atribui ao obj
            Veiculos v = new Veiculos();

            //recupera o codigo
            int cod = Convert.ToInt16(tbCodigo.Text);
            v = v.BuscaCod(cod);
            lista.Add(v);
            PreencherDGV();

        }

        public void limparCampos()
        {
            //limpa campos
            tbCodigo.Clear();
            maskTbDataInicio.Clear();
            masktbDataFim.Clear();
            tbNome.Text = "";
            tbCNH.Clear();
            cbTipoCli.Text = "";
        }

        //calcular valor de aluguel
        public void calcAluguel()
        {
           
           // int diarias = Convert.ToInt16(tbDiarias.Text);
            
            foreach (DataGridViewRow row in dgvVeiculo.Rows)
            {
                lbTotal.Text = Convert.ToString(Convert.ToDouble(clValorAluguel) * Convert.ToInt16(textBox1.Text));
                if (cbTipoCli.Text == "Coorporativo")
                {
                    lbTotal.Text = Convert.ToString(Convert.ToDouble(lbTotal.Text)-((Convert.ToDouble(lbTotal.Text) * 0.08)));
                }
                else
                {
                    lbTotal.Text = Convert.ToString(Convert.ToDouble(lbTotal.Text) - ((Convert.ToDouble(lbTotal.Text) * 0.05)));
                }
            }
        }

        private void btFinalizar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }
    }
}
