using System;
using System.IO;
using System.Windows.Forms;

namespace lr20_2
{
    public partial class ex2 : Form
    {
        public ex2()
        {
            InitializeComponent();
        }

        string fName;

        private void lr20_2_Load(object sender, EventArgs e)
        {
            //По умолчанию - один массив, т.е. одна строка в таблице
            dataGridView1.RowCount = 1;
            dataGridView1.Rows[0].HeaderCell.Value = "Массив 1";
        }

        private void btnMakeArr_Click(object sender, EventArgs e)
        {
            //Объект для работы с генератором случайных чисел
            Random rnd = new Random();
            //байтовый массив
            byte[] mas = new byte[10];
            //количество массивов берем из счетчика на форме
            int kol = (int)numericUpDown1.Value;
            //установить соответствующее кол-во строк в таблице
            dataGridView1.RowCount = kol;
            //запросить у пользователя имя двоичного файла для записи
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
 {
                //получить имя выбранного файла
                fName = saveFileDialog1.FileName;
                FileStream fs = new FileStream(fName, FileMode.Create);
                BinaryWriter bw = new BinaryWriter(fs);
                //цикл по количеству массивов
                for (int i = 0; i < kol; i++)
                {
                    //задать заголовок очередной строки в таблице
                    dataGridView1.Rows[i].HeaderCell.Value = "Массив " +(i + 1).ToString();
                    //цикл по элементам массива
                    for (int j = 0; j < 10; j++)
                    {
                        //очередной элемент массива - случайное число
                        mas[j] = (byte)(rnd.Next(1, 100));
                        //отобразить его в таблице
                        dataGridView1.Rows[i].Cells[j].Value = mas[j];
                    }
                    //записать массив в файл
                    bw.Write(mas);
                }
                bw.Close();
                fs.Close();
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //очистить список на форме
            listBox1.Items.Clear();
            FileStream fs = new FileStream(fName, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            byte[] mas = new byte[10];
            //номер очередного прочитанного из файла массива
            int n = 0;
             //строка-результат для вывода
             string res = "";
            //пока не дошли до конца файла
            while (br.PeekChar() >= 0)
            {
                //считать из файла очередной массив
                mas = br.ReadBytes(10);
                n++;
                res = "Массив " + n.ToString() + ": ";
                //если его номер четный - найти Max, иначе - Min
                if (n % 2 == 0)
                    res += ("max = " + MaxMin(mas, "Max").ToString());
                else
                    res += ("min = " + MaxMin(mas, "Min").ToString());
                //вывод результата в ListBox
                listBox1.Items.Add(res);
            }
            br.Close();
            fs.Close();
        }

        byte MaxMin(byte[] a, string choice)
        {
            byte M = a[0];
            if (choice == "Max")
                for (int i = 1; i < 10; i++)
                    if (a[i] > M)
                        M = a[i];
            if (choice == "Min")
                for (int i = 1; i < 10; i++)
                    if (a[i] < M)
                        M = a[i];
            return M;
        }

    }
}
