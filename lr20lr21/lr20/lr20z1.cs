using System;
using System.IO;
using System.Windows.Forms;

namespace lr20
{
    public partial class lr20z1 : Form
    {
        public lr20z1()
        {
            InitializeComponent();
        }

        string fName;
        
        private void btnSelectionFIle_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                //то получить имя выбранного файла
                fName = openFileDialog1.FileName;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            //открыть файл для ввода и дозаписи
            FileStream fs = new FileStream(fName, FileMode.Open);
            //создать объект для записи в текстовый файл
            StreamWriter sw = new StreamWriter(fs);
            int k = 0; // счетчик байтов
            char chStart='0', chOld='0', ch = '0';
            //ставим указатель на начало файла
            fs.Seek(0, SeekOrigin.Begin);
            //считываем данные из файла посимвольно
            bool isFirstCh = true;
            int x;
            do
            {
                //если не конец файла
                if (isFirstCh)
                {
                    x = fs.ReadByte();
                    ch = (char)x;
                    isFirstCh = !isFirstCh;
                }
                else
                {
                    x = fs.ReadByte();
                    chOld = ch;
                    ch = (char)x;
                }
                textBox1.Text += ch; //скопировать на форму
                if (ch == '\n' && chOld == chStart) k++;
                if (chOld=='\n') chStart = ch;
                chStart = ch;
            }
            while (x != -1);
            label1.Text = "Строк в начале и в конце которых один символ:" + k;
            sw.Close();
            fs.Close();
        }
    }
}
