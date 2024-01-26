using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr13
{
    public partial class Form1 : Form
    {
        private int[] Arr;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNewMas_Click(object sender, EventArgs e)
        {
            lblMas.Text = "";
            lblMas.Text = "";
            int n = int.Parse(txtQuant.Text);
            txtQuant.Text = Convert.ToString(n);
            try
            {
                Arr = new int[n];
                int a = int.Parse(txtMin.Text);
                int b = int.Parse(txtMax.Text);
                Random rand = new Random();
                for (int i=0; i<n;i++)
                {
                    Arr[i] = rand.Next(a,b);
                    lblMas.Text += Arr[i];
                    if (i < n-1) lblMas.Text += ", ";
                }
                btnMasSort.Enabled = true;
                btnMasSortNew.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Введите пределы массива");
            }
        }

        private void btnMasSort_Click(object sender, EventArgs e)
        {
            lblMasSort.Text = "";
            Array.Sort(Arr);
            for (int i=0;i<Arr.Length;i++)
            {
                lblMasSort.Text += Arr[i];
                if (i != Arr.Length) lblMasSort.Text += ", ";
            }
            btnMasSort.Enabled = false;
        }

        private void btnMasSortNew_Click(object sender, EventArgs e)
        {
            /*for (int i=1;i<Arr.Length;i++)
            {
                for (int j = i; j < Arr.Length-i; j++)
                {
                    
                }
            }*/
            Array.Sort(Arr);
            for (int i = 0; i < Arr.Length; i++)
            {
                lblMasSort.Text += Arr[i];
                if (i != Arr.Length) lblMasSort.Text += ", ";
            }
            btnMasSortNew.Enabled = false;
        }
    }
}
