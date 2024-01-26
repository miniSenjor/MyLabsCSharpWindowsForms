using System;
using System.Windows.Forms;

namespace lr11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (txtStr.Text!="" && txtSubstr.Text!="")
            {
                string str = txtStr.Text;
                string substr = txtSubstr.Text;
                txtRes.Text = Convert.ToString(NumberSymbols(str, substr));
            }
            else
            {
                MessageBox.Show("Введите строку");
            }
        }
        private int NumberSymbols(string stroka, string substr)
        {
            int k = 0;
            int lenSubstr = substr.Length;
            for (int i = 0; i < stroka.Length; i+=lenSubstr)
                for (int j = 0; j < substr.Length;j++)
                    if (stroka.Length>=i+j+lenSubstr)
                        if (stroka.Substring(i+j, lenSubstr) == substr)
                        {
                            k += 1;
                            break;
                        }
            return k;
        }
    }
}
