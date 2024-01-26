using System;
using System.Windows.Forms;

namespace lr18
{
    public partial class lr18_1 : Form
    {
        public lr18_1()
        {
            InitializeComponent();
        }

        string[] mas;

        private void btnSplit_Click(object sender, EventArgs e)
        {
            //исходная строка
            string s = txtString.Text;
            //массив разделителей состоит из одного элемента - пробела
            char[] sep = new char[] { ' ' };
            //разбиваем строку на слова и удаляем пустые строки
            mas = s.Split(sep, StringSplitOptions.RemoveEmptyEntries);
            //выводим слова в список на форме
            listBox1.Items.Clear();
            for (int i = 0; i < mas.Length; i++)
                listBox1.Items.Add(mas[i]);
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            string t = "";
            //сортировка слов методом "пузырька"
            for (int i = 0; i < mas.Length; i++)
                for (int j = mas.Length - 1; j > i; j--)
                    if (mas[j].CompareTo(mas[j - 1]) < 0)
                    {
                        t = mas[j];
                        mas[j] = mas[j - 1];
                        mas[j - 1] = t;
                    }
            //выводим отсортированные слова в список на форме
            listBox1.Items.Clear();
            for (int i = 0; i < mas.Length; i++)
                listBox1.Items.Add(mas[i]);
        }
    }
}
