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
            if (pol.SovleThePolynom(out x1, out x2) == -1)
            {
                label7.Text = "нет корней";
                label8.Text = "нет корней";
            }
            else
            {
                label7.Text = "x1=" + x1;
                label8.Text = "x2=" + x2;
            }
        }

        private void btnCalc2_Click(object sender, EventArgs e)
        {
            Polynomial pol = createPolynomialFromGropBox(groupBox2);
            double x1, x2;
            if (pol.SovleThePolynom(out x1, out x2)==-1)
            {
                label9.Text = "нет корней";
                label10.Text = "нет корней";
            }
            else
            {
                label9.Text = "x1=" + x1;
                label10.Text = "x2=" + x2;
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
            Polynomial pol2 = createPolynomialFromGropBox(groupBox2);
            pol1.Sum(pol1, pol2);
            lbResult.Text = "";
            for (int i = pol1.arr.Length-1; i >= 0; i--)
            {
                lbResult.Text += " " + pol1.arr[i];
                if (i > 0)
                {
                    lbResult.Text += $"x^{i}";
                    if (pol1.arr[i-1] >= 0) lbResult.Text += "+";
                }
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            Polynomial pol1 = createPolynomialFromGropBox(groupBox1);
            Polynomial pol2 = createPolynomialFromGropBox(groupBox2);
            pol1.Subtract(pol1, pol2);
            lbResult.Text = "";
            for (int i = pol1.arr.Length-1; i >=0; i--)
            {
                lbResult.Text += " " + pol1.arr[i];
                if (i > 0)
                {
                    lbResult.Text += $"x^{i}";
                    if (pol1.arr[i-1] >= 0) lbResult.Text += "+";
                }
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            Polynomial pol1 = createPolynomialFromGropBox(groupBox1);
            Polynomial pol2 = createPolynomialFromGropBox(groupBox2);
            pol1 = pol1.Multiply(pol1, pol2);
            lbResult.Text = "";
            for (int i = pol1.arr.Length-1; i >=0 ; i--)
            {
                lbResult.Text += " " + pol1.arr[i];
                if (i > 0)
                {
                    lbResult.Text += $"x^{i}";
                    if (pol1.arr[i-1] >= 0) lbResult.Text += " +";
                }
            }
        }

        private Polynomial createPolynomialFromGropBox(GroupBox groupBox)
        {
            int i = 0;
            double[] arrPol = new double[3];
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

        private void z1_Load(object sender, EventArgs e)
        {
            lbResult.Text = "";
        }

        private void btnShowInfo1_Click(object sender, EventArgs e)
        {
            Polynomial pol = createPolynomialFromGropBox(groupBox1);
            label11.Text = "Многочлен1: ";
            if (pol.arr[2]!=0)
            {
                label11.Text += "график парабола";
                if (pol.arr[2] > 0) label11.Text += "ветви вверх";
                else label11.Text += "ветви вниз";
            }
            else
            {
                label11.Text += "график прямая";
            }
        }

        private void btnShowInfo2_Click(object sender, EventArgs e)
        {
            Polynomial pol = createPolynomialFromGropBox(groupBox2);
            label12.Text = "Многочлен2: ";
            if (pol.arr[2] != 0)
            {
                label12.Text += "график парабола";
                if (pol.arr[2] > 0) label12.Text += "ветви вверх";
                else label12.Text += "ветви вниз";
            }
            else
            {
                label12.Text += "график прямая";
            }
        }
    }
}

