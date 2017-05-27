using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            bool validar = false;
            if (tbLogin.Text == "Xicão" && tbSenha.Text == "123")
            {
                Form1 frm = new Form1();
                frm.Show();
                validar = true;
                this.Hide();
            }
            
        }
    }
}
