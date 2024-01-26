using System;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace lr8z2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] arr;
        private void btnCalc_Click(object sender, EventArgs e)
        {
            arr = new int[15];
            Random rand = new Random();
            txtArray.Text = "Массив: ";
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(20);
                txtArray.Text += arr[i].ToString() + " ";
            }
            txtArray.Text += @"
Max="+arr.Max();
            txtArray.Text += @"
Min=" + arr.Min();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (arr!=null)
            {
                Array.Sort(arr);
                txtArray.Text = "Массив: "; for (int i = 0; i < arr.Length; i++)
                {
                    txtArray.Text += arr[i].ToString() + " ";
                }
                txtArray.Text += @"
Max=" + arr.Max();
                txtArray.Text += @"
Min=" + arr.Min();
            }
            else MessageBox.Show("Массив не создан!");
        }
    }
}
