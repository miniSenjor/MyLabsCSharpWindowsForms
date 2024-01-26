using System;
using System.Windows.Forms;
using MathNet.Numerics;

namespace lr6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFack_Click(object sender, EventArgs e)
        {
            double x;
            double n;
            if (double.TryParse(txtX.Text, out x))
            {
                if (btnChange.Text == "x^n")
                    txtFack.Text = Convert.ToString(Math.Round(SpecialFunctions.Gamma(1 + x), 3));
                else if (double.TryParse(txtN.Text, out n)) txtFack.Text = Convert.ToString(Math.Round(Math.Pow(x,n)));
                    else MessageBox.Show("введите число");
            }
            else MessageBox.Show("введите число");
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (btnChange.Text == "x^n")
            {
                btnChange.Text = "x!";
                lblFack.Text = "x^n=";
                lblN.Visible = true;
                txtN.Visible = true;
            }
            else
            {
                btnChange.Text = "x^n";
                lblFack.Text = "x!=";
                lblN.Visible = false;
                txtN.Visible = false;
            }
        }
    }
}
