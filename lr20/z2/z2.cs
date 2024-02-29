using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;

namespace lr20z2
{
    public partial class z2 : Form
    {
        public z2()
        {
            InitializeComponent();
        }

        string fName="";

        struct Date
        {
            public string day;
            public string month;
            public string year;
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //то получить имя выбранного файла
                fName = openFileDialog1.FileName;
                label2.Text = fName;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (fName=="")
            {
                MessageBox.Show("Веберите файл");
                return;
            }
            int endNewFile=0;
            string[] s = File.ReadAllLines(fName);

            Date enteredDate=convertStringToDate(txtEnteredDate.Text);

            Date[] dates = new Date[s.Length];
            for (int i=0;i<s.Length;i++)
            {
                if (Convert.ToInt32(convertStringToDate(s[i]).year) > Convert.ToInt32(enteredDate.year))
                {
                    endNewFile = i;
                    break;
                }
                else if (Convert.ToInt32(convertStringToDate(s[i]).year) == Convert.ToInt32(enteredDate.year) && Convert.ToInt32(convertStringToDate(s[i]).month) > Convert.ToInt32(enteredDate.month))
                {
                    endNewFile = i;
                    break;
                }
                else if (Convert.ToInt32(convertStringToDate(s[i]).year) == Convert.ToInt32(enteredDate.year) && Convert.ToInt32(convertStringToDate(s[i]).month) == Convert.ToInt32(enteredDate.month) && Convert.ToInt32(convertStringToDate(s[i]).day) > Convert.ToInt32(enteredDate.day))
                {
                    endNewFile = i;
                    break;
                }
                else
                    dates[i] = convertStringToDate(s[i]);
            }

            if (endNewFile == 0 || endNewFile == s.Length)
            {
                FileStream fs = new FileStream(fName, FileMode.Append);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(txtEnteredDate.Text);
                sw.Close();
                fs.Close();
            }
            else
            {
                FileStream fs = new FileStream(fName, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);
                for (int i = 0; i < endNewFile; i++)
                {
                    sw.WriteLine(dates[i].day + "." + dates[i].month + "." + dates[i].year);
                }

                sw.Close();
                fs.Close();
            }
        }

        private Date convertStringToDate(string s) 
        {
            Date date = new Date();
            date.year = "";
            date.day = s[0].ToString();
            date.day += s[1];
            date.month = s[3].ToString();
            date.month += s[4];
            for (int j = 6; j < s.Length; j++)
            {
                date.year += s[j];
            }

            return date;
        }
    }
}
