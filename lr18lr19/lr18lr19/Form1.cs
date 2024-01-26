using System;
using System.Windows.Forms;

namespace lr18lr19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn10Convert2_Click(object sender, EventArgs e)
        {
            try
            {
                txt2.Text = "";
                int a=int.Parse(txt10.Text);
                string res="";
                while (a>0)
                {
                    res = res.Insert(0, (a%2).ToString());
                    a /= 2;
                }
                txt2.Text = res;
            }
            catch 
            {
                MessageBox.Show("Введите число");
            }
        }

        private void btn2Convert10_Click(object sender, EventArgs e)
        {
            try
            {
                txt10.Text = "";
                string a =  txt2.Text;
                double res = 0;
                for (int i = a.Length-1; i>=0; i--)
                {
                    if (a[i]=='1')
                    res += Math.Pow(2,a.Length-i-1);
                }
                txt10.Text = res.ToString();
            }
            catch 
            {
                MessageBox.Show("Введите число");                
            }
        }
    }
}
