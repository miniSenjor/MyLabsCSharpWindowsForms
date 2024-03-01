using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace z3
{
    public partial class z3 : Form
    {
        public z3()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b, y, x;
                a = double.Parse(txtA.Text);
                b = double.Parse(txtB.Text);
                if (rb1.Checked)
                    x = double.Parse(rb1.Text);
                else if (rb2.Checked)
                    x = double.Parse(rb2.Text);
                else x = double.Parse(rb3.Text);
                y = (b + a/Math.Cos(x)*Math.Exp(-b)*Math.Sqrt(b+a));
                txtY.Text = y.ToString();
                btnSave.Enabled = true;
            }
            catch 
            {
                MessageBox.Show("Ошибка ввода");
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            string fName = saveFileDialog1.FileName;
            File.WriteAllText(fName, "y="+txtY.Text+"\r\n");
        }
    }
}
