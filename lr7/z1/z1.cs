using System;
using System.Drawing;
using System.Windows.Forms;

namespace z1
{
    public partial class z1 : Form
    {
        public z1()
        {
            InitializeComponent();
        }

        int x = 5;
        int y = 5;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pct.Top <= 0)
                y = 5;
            else if (pct.Bottom >= this.Height-37)
                y = -5;

            if (pct.Left <= 0)
                x = 5;
            else if (pct.Right >= this.Width-14)
                x = -5;

            pct.Left += x;
            pct.Top += y;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                btnStart.Text = "Start";
                timer1.Enabled = false;
                pct.Location = new Point( 28, 23);
            }
            else
            {
                btnStart.Text = "Stop";
                timer1.Enabled = true;
                timer1.Interval = 50;
            }
        }
    }
}
