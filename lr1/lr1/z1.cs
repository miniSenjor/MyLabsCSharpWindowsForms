﻿using System;
using System.Windows.Forms;

namespace lr1
{
    public partial class z1 : Form
    {
        public z1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            int summa = Int32.Parse(txtA.Text) +
            Int32.Parse(txtB.Text) + Int32.Parse(txtC.Text);
            txtSum.Text = summa.ToString();
        }
    }
}
