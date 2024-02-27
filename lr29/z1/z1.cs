using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace z1
{
    public partial class z1 : Form
    {
        public z1()
        {
            InitializeComponent();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInput input = new FormInput();
            input.Show();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //dataGridView1.SelectedRows
            //dataGridView1.Rows[dataGridView1.SelectedRows[0]]
        }
    }

    public class Record
    {
        public string lastName;
        public string address;
        public string phone;

    }
}
