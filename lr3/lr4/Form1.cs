using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Работа с текстом";
            label1.Text = "Операции с текстом";
            label1.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.White;
        }

        private void красныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Red;
        }

        private void зеленыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
            label1.BackColor = Color.White;
            label1.ForeColor = Color.Black;
        }

        private void белыйТекстToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.White;
        }

        private void сбросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
            label1.BackColor = Color.White;
            label1.ForeColor = Color.Black;
        }
    }
}
