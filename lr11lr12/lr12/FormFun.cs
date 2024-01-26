using System;
using System.Windows.Forms;
using static System.Math;

namespace lr12
{
    public partial class FormFun : Form
    {
        public FormFun()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {

            double a = double.Parse(txtA.Text);
            double b;
            PowerA3(a, out b);
            txtB.Text = Convert.ToString(b);
            }
            catch
            {
                MessageBox.Show("Введите a!");
            }
        }

        private void PowerA3(double a, out double b)
        {
            b = Pow(a, 3);
        }
    }
}
