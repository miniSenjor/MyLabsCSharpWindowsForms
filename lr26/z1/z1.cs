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
            lBYourOptions.Items.Clear();
            lBBulls.Items.Clear();
            lBCows.Items.Clear();
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
                if (yourOption.Length!=4 || !int.TryParse(txtInput.Text,out ckeck) || ckeckRepeatNumber(yourOption))
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
                lBYourOptions.Items.Add(yourOption + "\r\n");
                lBBulls.Items.Add(bulls + "\r\n");
                lBCows.Items.Add(cows + "\r\n");
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

        bool ckeckRepeatNumber(string yourOption)
        {
            for (int i = 0; i<yourOption.Length; i++)
                for (int j=i+1; j<yourOption.Length; j++)
                    if (yourOption[i] == yourOption[j])
                        return true;
            return false;
        }

        private void btnStartAI_Click(object sender, EventArgs e)
        {
            int bulls=0, cows=0;
            string userNumber = txtYourNumber.Text;
            List<char> notUsedNumber = new List<char>() { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            string aiNumber = "01234";
            if(!checkContain(userNumber, aiNumber, ref bulls, ref cows))


            while (bulls<4)
            {

            }
        }

        bool checkContain(string userNumber, string option, ref int bulls, ref int cows)
        {
            for (int i = 0; i < 4; i++)
            {
                if (option.IndexOf(userNumber[i]) != -1)
                {
                    if (option.IndexOf(userNumber[i]) == i)
                        bulls++;
                    else cows++;
                }
            }
            lBAIOption.Items.Add(option + "\r\n");
            lBAIBulls.Items.Add(bulls + "\r\n");
            lBAICows.Items.Add(cows + "\r\n");
            if (cows == 0 && bulls == 0)
                return false;
            else return true;
        }
    }
}
