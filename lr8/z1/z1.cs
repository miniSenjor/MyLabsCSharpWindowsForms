using System;
using System.Windows.Forms;

namespace lr8
{
    public partial class z1 : Form
    {
        public z1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int[] arr = new int[10];
            int sum = 0;
            Random rand = new Random();
            txtArray.Text = "Массив: ";
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(20);
                sum += arr[i];
                txtArray.Text += arr[i].ToString() + " ";
            }
            txtArray.Text += @"
Сумма:" + sum;
            txtArray.Text += @"
Ср арифм.:" + sum / 10;
        }
    }
}
