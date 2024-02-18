using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace z1
{
    public partial class z1 : Form
    {
        public z1()
        {
            InitializeComponent();
        }

        string number;

        private void btnYourStart_Click(object sender, EventArgs e)
        {
            number = "";
            List<int> notUsedNumber = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            Random rand = new Random();
            for(int i=0;i<4;i++)
            {
                int r = rand.Next(notUsedNumber.Count);
                number += notUsedNumber[r];
                notUsedNumber.RemoveAt(r);
            }
            label1.Text = number;
            btnInput.Enabled = true;
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            try
            {
                string yourOption = txtInput.Text;
                int ckeck;
                if (yourOption.Length!=4 || !int.TryParse(txtInput.Text,out ckeck) || ckeckRepeatNumber(number))
                {
                    MessageBox.Show("Некоректное число");
                    return;
                }

                int cows = 0, bulls = 0;
                for (int i=0;i<4;i++)
                {
                    if (yourOption.IndexOf(number[i])!=-1)
                    {
                        if (yourOption.IndexOf(number[i]) == i)
                            bulls++;
                        else cows++;
                    }
                }
                txtBulls.Text += bulls + "\r\n";
                txtCows.Text += cows + "\r\n";
                txtYourOptions.Text += yourOption + "\r\n";
                txtInput.Text = "";
                if (bulls==4)
                {
                    MessageBox.Show("Вы угадали!!!");
                    btnInput.Enabled = false;
                }
            }
            catch
            {
                MessageBox.Show("Некоректное число");
            }
        }

        bool ckeckRepeatNumber(string number)
        {
            for (int i =0;i<number.Length;i++)
                for (int j=i+1;j<i;j++)
                {
                    if (number[i] == number[j])
                        return true;
                }
            return false;
        }

        private void btnStartAI_Click(object sender, EventArgs e)
        {
            int bulls=0, cows=0;
            while (bulls<4)
            {

            }
        }
    }
}
