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
            Random rand = new Random();
            int bulls = 0, cows = 0;
            string userNumber = txtYourNumber.Text;
            List<char> numbers = new List<char>() { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };

            string aiNumber = "0123";
            guessNumber(userNumber, aiNumber, numbers, rand, ref bulls, ref cows);
            if (bulls == 4)
                return;
            aiNumber = "4567";
            guessNumber(userNumber, aiNumber, numbers, rand, ref bulls, ref cows);
            if (bulls == 4)
                return;
            aiNumber = "8901";
            guessNumber(userNumber, aiNumber, numbers, rand, ref bulls, ref cows);
            if (bulls == 4)
                return;

            aiNumber = "";
            while (bulls < 4)
            {
                guessNumber(userNumber, aiNumber, numbers, rand, ref bulls, ref cows);
            }
        }

        void guessNumber(string userNumber, string aiNumber, List<char> numbers, Random rand, ref int bulls, ref int cows)
        {
            List<char> notUsedNumber = new List<char>();
            for (int i=0; i<numbers.Count; i++)
                notUsedNumber.Add(numbers[i]);
            if(aiNumber=="")
            {
                for (int i = 0; i < 4; i++)
                {
                    int r = rand.Next(notUsedNumber.Count);
                    aiNumber += notUsedNumber[r];
                    notUsedNumber.RemoveAt(r);
                }
            }
            bool b = checkContain(userNumber, aiNumber, ref bulls, ref cows);
            if (!b) for (int i = 0; i < aiNumber.Length; i++)
                    numbers.Remove(aiNumber[i]);
            if (bulls + cows == 4)
            {
                numbers = new List<char>();
                for (int i = 0; i < aiNumber.Length; i++)
                    numbers.Add(aiNumber[i]);
            }
        }

        bool checkContain(string userNumber, string option, ref int bulls, ref int cows)
        {
            bulls = 0;
            cows = 0;
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
