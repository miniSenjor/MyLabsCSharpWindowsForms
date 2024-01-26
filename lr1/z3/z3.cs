using System;
using System.Windows.Forms;

namespace z3
{
    public partial class z3 : Form
    {
        public z3()
        {
            InitializeComponent();
            lst.Items.Add("black");
            lst.Items.Add("red");
            lst.Items.Add("blue");
            lst.Items.Add("green");
            lstWidth.Items.Add("20");
            lstWidth.Items.Add("50");
            lstWidth.Items.Add("100");
        }

        private void lst_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst.SelectedItem == "black")
            {
                txt.BackColor = System.Drawing.Color.Black;
            }
            else if (lst.SelectedItem == "red")
            {
                txt.BackColor = System.Drawing.Color.Red;
            }
            else if (lst.SelectedItem == "blue")
            {
                txt.BackColor = System.Drawing.Color.Blue;
            }
            else if (lst.SelectedItem == "green")
            {
                txt.BackColor = System.Drawing.Color.Green;
            }
        }

        private void lstWidth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstWidth.SelectedItem == "20")
            {
                txt.Width = 20;
            }
            else if (lstWidth.SelectedItem == "50")
            {
                txt.Width = 50;
            }
            else if (lstWidth.SelectedItem == "100")
            {
                txt.Width = 100;
            }
        }
    }
}
