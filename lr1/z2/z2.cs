using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace z2
{
    public partial class frmSqr : Form
    {
        public frmSqr()
        {
            InitializeComponent();
        }

        private void radio1_CheckedChanged(object sender, EventArgs e)
        {
            txt1.Text = "cторона 1=";
            txt2.Text = "cторона 2=";
            txt3.Text = "cторона 3=";
            edit1.Text = "";
            edit2.Text = "";
            edit3.Text = "";
            edit3.Visible = true;
            txt3.Visible = true;
            txtExit.Text = "";
        }

        private void radio2_CheckedChanged(object sender, EventArgs e)
        {
            txt1.Text = "cторона 1=";
            txt2.Text = "cторона 2=";
            edit1.Text = "";
            edit2.Text = "";
            edit3.Visible = false;
            txt3.Visible = false;
            txtExit.Text = "";
        }

        private void radio3_CheckedChanged(object sender, EventArgs e)
        {
            txt1.Text = "cторона 1=";
            txt2.Text = "cторона 2=";
            txt3.Text = "угол =";
            edit1.Text = "";
            edit2.Text = "";
            edit3.Text = "";
            edit3.Visible = true;
            txt3.Visible = true;
            txtExit.Text = "";
        }

        private void radio4_CheckedChanged(object sender, EventArgs e)
        {
            txt1.Text = "число =";
            txt2.Text = "%=";
            edit1.Text = "";
            edit2.Text = "";
            edit3.Visible = false;
            txt3.Visible = false;
            txtExit.Text = "";
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            if (radio1.Checked)
                AreaTriangle3();
            else if (radio2.Checked)
                AreaSqr();
            else if (radio3.Checked)
                AreaTriangle2();
            else Percent();
        }
        private void AreaTriangle3()
        {
            float a = float.Parse(edit1.Text);
            float b = float.Parse(edit2.Text);
            float c = float.Parse(edit3.Text);
            float p = (a + b + c) / 2;
            if (a + b < c && a + c < b && b + c <a)
                txtExit.Text = Convert.ToString(Math.Sqrt(p *(p-a)* (p - b) * (p - c)));
        }
        private void AreaSqr()
        {
            float a = float.Parse(edit1.Text);
            float b = float.Parse(edit2.Text);
            txtExit.Text = Convert.ToString(a*b);
        }
        private void AreaTriangle2()
        {
            float a = float.Parse(edit1.Text);
            float b = float.Parse(edit2.Text);
            double c = double.Parse(edit3.Text)*Math.PI/180;
            if (c<180) txtExit.Text = Convert.ToString((a * b*Math.Sin(c))/2);
        }
        private void Percent()
        {
            float a = float.Parse(edit1.Text);
            float b = float.Parse(edit2.Text);
            txtExit.Text = Convert.ToString(a*b/100);
        }
    }
}
