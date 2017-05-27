using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace DataGridView
{
    public partial class Form1 : Form
    {
        
        //coleção de obj da classe pessoa
        List<Pessoa> lista = new List<Pessoa>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();

            if (mtxtRG.Text == string.Empty || mtxtCPF.Text == string.Empty || txtNome.Text == string.Empty)
            {
                MessageBox.Show("Campos em branco \nFavor preencher", "Alerta");
            }
            else
            {
                pessoa.Nome = txtNome.Text;

                // 0 - Masculino; 1 - Feminino
                if (cbSexo.SelectedIndex == 0)
                {
                    pessoa.Sexo = 'M';
                }
                else
                {
                    pessoa.Sexo = 'F';
                }

                pessoa.DataNascimento = dtpDataNascimento.Text;

                if (rbSim.Checked)
                {
                    pessoa.NecessidadesEspeciais = true;
                }
                else
                {
                    pessoa.NecessidadesEspeciais = false;
                }

                pessoa.RG = mtxtRG.Text;
                pessoa.CPF = mtxtCPF.Text;

                //adiona objs na lista
                lista.Add(pessoa);

                //chama método de preenchimento
                preencherDgv();

                //limpacampos para evitar preenchimento duplo
                limparCampos();
            }
            
        }

        //método de preenchimento do DGV
        private void preencherDgv()
        {
            //limpar DGV
            dgvClientes.Rows.Clear();

            for (int i = 0; i < lista.Count; i++)
            {
                string[] nova_linha = new string[]
                {
                    lista[i].Nome,
                    lista[i].DataNascimento,
                    lista[i].Sexo == 'F' ? "Feminino" : "Masculino",
                    lista[i].CPF, lista[i].RG,
                    lista[i].NecessidadesEspeciais == false ? "Não" : "Sim"
                };
                dgvClientes.Rows.Add(nova_linha);
            }
        }

        //método de limpar campos
        private void limparCampos()
        {
            //limpa campos de texto
            txtNome.Clear();

            //volta para dat atual do sistema
            dtpDataNascimento.Value = DateTime.Now;

            //limpa combobox
            cbSexo.Text = "";

            //retira o checked
            if (rbSim.Checked)
            {
                rbSim.Checked = false;
            }
            else
            {
                rbNao.Checked = false;
            }

            //limpa campos de texto
            mtxtCPF.Clear();
            mtxtRG.Clear();


        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /* 
            CurrentRow - recupera a linha selecionada

            Cells[i] - idica qual celula da grid a partir de 0

            Value - Recupera o valor da célula

            ToString - converte pra string um valor.

             */

            txtNome.Text = dgvClientes.CurrentRow.Cells[0].Value.ToString();
            dtpDataNascimento.Text = dgvClientes.CurrentRow.Cells[1].Value.ToString();
            mtxtRG.Text = dgvClientes.CurrentRow.Cells[2].Value.ToString();
            mtxtCPF.Text = dgvClientes.CurrentRow.Cells[3].Value.ToString();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
           
            //verifica se há dados para excluir
            if (mtxtRG.Text == string.Empty && mtxtCPF.Text == string.Empty && txtNome.Text == string.Empty)
            {
                MessageBox.Show("Não há dados para serem excluidos!");
            }
            else
            {
                //confirmação para exclusão
                DialogResult resposta = MessageBox.Show("Deseja continuar a operação?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resposta == DialogResult.Yes)
                {
                    if (dgvClientes.RowCount !=0)
                    {
                        //recupera o indice da linha selecionada
                         int indiceLinha = dgvClientes.CurrentRow.Index;

                        //remove da lista
                        lista.RemoveAt(indiceLinha);

                        //chama o método limpar campos
                        limparCampos();

                        //limpa a grid
                        dgvClientes.Rows.Clear();

                        //atualiza a grid
                        preencherDgv();
                    }
                    else 
                    {
                        MessageBox.Show("Selecione um indice");
                    }

                }
            }

           
           
        }
    }
}
