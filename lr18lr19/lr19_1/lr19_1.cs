using System;
using System.Windows.Forms;

namespace lr19_1
{
    public partial class lr19_1 : Form
    {
        public lr19_1()
        {
            InitializeComponent();
        }

        //структура "Дата"
        struct Date
        {
            public int number;
            public int month;
            public int year;
        }

        //структура "Человек"
        struct Person
        {
            public string FIO;
            public Date Birthday;
        }
        //описание массива людей
        Person[] mas;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //берем данные о человеке из компонентов на форме
            string fio = txtFIO.Text;
            DateTime birthday = dateTimePicker1.Value;
            //и заносим их в таблицу dataGridView1
            dataGridView1.Rows.Add(fio, birthday.ToShortDateString());
            txtFIO.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //определяем кол-во людей в массиве
            int n = dataGridView1.RowCount;
            mas = new Person[n];
            //записываем данные из таблицы на форме в массив mas
            for (int i = 0; i < n; i++)
            {
                mas[i].FIO = (string)dataGridView1.Rows[i].Cells[0].Value;
                DateTime dt = Convert.ToDateTime(dataGridView1.Rows[i].Cells[1].Value);
                mas[i].Birthday.number = dt.Day;
                mas[i].Birthday.month = dt.Month;
                mas[i].Birthday.year = dt.Year;
            }
            //элемент массива, соответствующий самому младшему человеку
            Person min = mas[0];
            //его порядковый номер в массиве
            int ind = 0;
            //ищем самого младшего
            for (int i = 1; i < n; i++)
                if (mas[i].Birthday.year > min.Birthday.year)
                {
                    min = mas[i];
                    ind = i;
                }
            //выводим его ФИО на форму
            label3.Text = mas[ind].FIO;
        }
    }
}
