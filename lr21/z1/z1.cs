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

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int i = 0;
            float[] arrPol = new float[3];
            foreach (TextBox textBox in groupBox1.Controls.OfType<TextBox>())
            {
                arrPol[i] = float.Parse(textBox.Text);
                i++;
            }
            Polynomial pol = new Polynomial(arrPol);
            float x1, x2;
            pol.SovleThePolynom(out x1, out x2);
            lbX1.Text = "x1=" + x1;
            lbX2.Text = "x2=" + x2;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (TextBox textBox in groupBox1.Controls.OfType<TextBox>())
            {
                textBox.Text = "";
            }
        }
    }
}
