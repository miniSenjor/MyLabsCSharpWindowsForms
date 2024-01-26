using System;
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
            int counter = 0; // количество слагаемых
            double sum = 0; // сумма
            double summand = 0.0; // слагаемое
            double x;
            double precision;

            bool f = false;
            if (double.TryParse(txtPrecision.Text, out precision))
                f = true;
            if (f) lblResult.Text = "сумма = " + sum + ", количество = " + counter;
            else MessageBox.Show("введите числовое значение!");
            do
            {
                counter++;
                if (double.TryParse(txtX.Text, out x))
                    summand = x / counter;
                sum += summand;
                Console.WriteLine($"counter={counter} x={x} summand={summand} sum={sum} precision={precision}");
            } while (f && Math.Abs(summand)>precision);

            lblResult.Text = "сумма = " + sum + ", количество = " + counter;
        }
    }
}
