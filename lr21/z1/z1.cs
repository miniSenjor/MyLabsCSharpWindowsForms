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

        private void btnCalc1_Click(object sender, EventArgs e)
        {
            Polynomial pol = createPolynomialFromGropBox(groupBox1);
            double x1, x2;
            pol.SovleThePolynom(out x1, out x2);
            lbX1.Text = "x1=" + x1;
            lbX2.Text = "x2=" + x2;
        }

        private void btnCalc2_Click(object sender, EventArgs e)
        {
            Polynomial pol = createPolynomialFromGropBox(groupBox2);
            double x1, x2;
            if (pol.SovleThePolynom(out x1, out x2)==-1)
            {
                lbX1.Text = "нет корней";
                lbX2.Text = "нет корней";
            }
            else
            {
                lbX1.Text = "x1=" + x1;
                lbX2.Text = "x2=" + x2;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (TextBox textBox in groupBox1.Controls.OfType<TextBox>())
            {
                textBox.Text = "";
            }
            foreach (TextBox textBox in groupBox2.Controls.OfType<TextBox>())
            {
                textBox.Text = "";
            }
            lbResult.Text = "";
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            Polynomial pol1 = createPolynomialFromGropBox(groupBox1);
            Polynomial pol2 = createPolynomialFromGropBox(groupBox1);
            pol1.Sum(pol1, pol2);
            lbResult.Text = "";
            for (int i = 0; i < pol1.arr.Length; i++)
                lbResult.Text += pol1.arr[i];
        }

        private void btnSub_Click(object sender, EventArgs e)
        {

        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {

        }

        private Polynomial createPolynomialFromGropBox(GroupBox groupBox)
        {
            int i = 0;
            float[] arrPol = new float[3];
            foreach (TextBox textBox in groupBox.Controls.OfType<TextBox>())
            {
                try
                {
                    arrPol[i] = float.Parse(textBox.Text);
                }
                catch
                {
                    arrPol[i] = 0;
                    textBox.Text = "0";
                }
                i++;
            }
            Polynomial pol = new Polynomial(arrPol);
            return pol;
        }
    }
}
