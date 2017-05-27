using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listBox_Eventos
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btListBoxV1_Click(object sender, EventArgs e)
        {
            FormListBoxV1 frmv = new FormListBoxV1();
            frmv.Show();
        }

        private void btListBoxV2_Click(object sender, EventArgs e)
        {
            FormListBoxV2 frmv = new FormListBoxV2();
            frmv.Show();
        }

        private void btCheckedList_Click(object sender, EventArgs e)
        {
            FormCheckedListBox frmv = new FormCheckedListBox();
            frmv.Show();
        }

        private void btComboBox_Click(object sender, EventArgs e)
        {
            FormComboBox frmv = new FormComboBox();
            frmv.Show();
            this.Close();
        }
    }
}
