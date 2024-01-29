using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;

namespace lr20z2
{
    public partial class lr20z2 : Form
    {
        public lr20z2()
        {
            InitializeComponent();
        }

        string fName;

        struct Date
        {
            public string day;
            public string month;
            public string year;
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                //то получить имя выбранного файла
                fName = openFileDialog1.FileName;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            /*string[] s = File.ReadAllLines(fName);
            Date[] dates = new Date[s.Length];
            string day, month, year;
            for (int i=0;i<s.Length;i++)
            {
                dates[i].day = Convert.ToString(s[i][0] + s[i][1]);
                dates[i].month = Convert.ToString(s[i][3] + s[i][4]);
                dates[i].day = Convert.ToString(s[i][0] + s[i][1]);
                //dates[i] = s[i];
            }

            //создать объект для записи в текстовый файл
            Date date;
            using (FileStream fileStream = new FileStream(fName, FileMode.Open))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                while (fileStream.Position < fileStream.Length)
                {
                    date = (Date)binaryFormatter.Deserialize(fileStream);
                }
            }*/
            List<Date> dates = new List<Date>();
            FileStream fs = new FileStream(fName, FileMode.Open, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine();
        }
    }
}
