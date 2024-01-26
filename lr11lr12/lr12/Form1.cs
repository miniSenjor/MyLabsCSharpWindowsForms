using System;
using System.Linq;
using System.Windows.Forms;

namespace lr12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void демонстрацияРаботыСМассивамиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMas newformMas = new FormMas();
            newformMas.Show();
        }

        private void демонстрацияРаботыСФункциямиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFun newformFun = new FormFun();
            newformFun.Show();
        }

        private void демонстрацияРаботыСоСтрокамиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStr newformStr = new FormStr();
            newformStr.Show();
        }
    }
}
