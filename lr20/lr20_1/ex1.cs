using System;
using System.IO;
using System.Windows.Forms;

namespace lr20_1
{
    public partial class ex1 : Form
    {
        public ex1()
        {
            InitializeComponent();
        }

        string fName;

        private void btnSelectionFIle_Click(object sender, EventArgs e)
        {
            //показать стандартное диалоговое окно выбора файла
            //и, если пользователь нажал в нем кнопку "Открыть",
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
            char ch;
            //ставим указатель на начало файла
            fs.Seek(0, SeekOrigin.Begin);
            //считываем данные из файла посимвольно
            int x;
            do
            {
                //читаем очередной байт
                x = fs.ReadByte();
                //если не конец файла
                if (x != -1)
                {
                    //переводим считанный байт в символ
                    ch = (char)x;
                    textBox1.Text += ch; //скопировать на форму
                    k++;
                    if (ch == '\n') //если конец строки
                    {
                        // запомнить текущую позицию
                        long pos = fs.Position;
                        //переместить указатель вывода в конец файла
                        fs.Seek(0, SeekOrigin.End);
                        sw.Write(k + " ");
                        // восстановить позицию
                        fs.Seek(pos, SeekOrigin.Begin);
                    }
                }
            }
            while (x != -1);
            //вывести окончательное значение счетчика байтов
            sw.Write(k + " ");
            textBox1.Text += ("[ " + k + " ]");
            sw.Close();
            fs.Close();
        }
    }
}
