using System;
using System.Windows.Forms;

namespace lr10
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void форма1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newForm2 = new Form2();
            newForm2.Show();
        }

        private void форма2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 newForm3 = new Form3();
            newForm3.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
