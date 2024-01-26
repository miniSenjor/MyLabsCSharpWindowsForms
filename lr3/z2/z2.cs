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
    public partial class z2 : Form
    {
        public z2()
        {
            InitializeComponent();
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            int tmpS, tmpM;
            if (txtSec.Text == "") tmpS = 0;
            else tmpS = Int32.Parse(txtSec.Text);
            if (txtMin.Text == "") tmpM = 0;
            else tmpM = Int32.Parse(txtMin.Text);
            if (tmpS == 59)
            {
                tmpS = 0;
                tmpM += 1;
            }
            else tmpS += 1;
            txtSec.Text = tmpS.ToString();
            txtMin.Text = tmpM.ToString();
            txtDateNow.Text = DateTime.Now.ToString();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (tmr.Enabled==false)
            {
                btnStart.Text = "Остановить";
                tmr.Enabled = true;
            }
            else
            {
                btnStart.Text = "Старт";
                tmr.Enabled = false;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tmr.Enabled = false;
            txtMin.Text = "";
            txtSec.Text = "";
        }

    }
}
