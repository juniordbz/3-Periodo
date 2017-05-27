using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_CRUD.Model;

namespace Projeto_CRUD
{
    public partial class formCadastro : Form
    {
        public formCadastro()
        {
            InitializeComponent();
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            
            //validação do usuário adm
            if (cbOp.Text == "Admin" && tbSenha.Text == "123" && tbUsuario.Text== "Admin" | tbUsuario.Text == "admin")
            {
                formCadastro_Funcionario frmFunc= new formCadastro_Funcionario();
                frmFunc.Show();     //abre form de Cad de func. 
                this.Hide();        //fecha formularia inicial
            }

            //validação dos funcionários
            if (cbOp.Text == "Funcionário")
            {
               formCad_Produtos frmProd= new formCad_Produtos();
                frmProd.Show();     //abre form de Cad de func. 
                this.Hide();        //fecha formularia inicial
            }
        }


    }
}
