using System;
using System.Windows.Forms;

namespace lr18_3
{
    public partial class lr18_3 : Form
    {
        public lr18_3()
        {
            InitializeComponent();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            decimal n = numericUpDown1.Value;
            string s = n.ToString();
            int sum = 0;
            for (int i = 0; i < s.Length; i++)
                sum += Convert.ToInt32(s[i].ToString());
            label2.Text = "Сумма цифр = " + sum;
        }
    }
}
