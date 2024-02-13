using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ex1
{
    public partial class ex1 : Form
    {
        public ex1()
        {
            InitializeComponent();
        }

        ArrayList points, res; //объявление динамических массивов
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //берем значения из компонентов-счетчиков
            float x = (float)XnumericUpDown.Value;
            float y = (float)YnumericUpDown.Value;
            //создаем новую точку
            Point p = new Point(x, y);
            //добавляем ее в коллекцию
            points.Add(p);
            //добавляем в таблицу на форме
            dataGridView1.Rows.Add(p.x, p.y);
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            //очистить коллекцию res
            res.Clear();
            //очистить содержимое таблиц на форме
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            //просматриваем исходный массив
            foreach (Point p in points)
                if (p.x < 0) //при выполнении условия
                    res.Add(p); //добавляем точку в массив-результат
            foreach (Point p in res)
            {
                //удаляем найденные точки из исходного массива
                points.Remove(p);
                //отображаем 2-й массив в таблице на форме
                dataGridView2.Rows.Add(p.x, p.y);
            }
            foreach (Point p in points)
                //отображаем 1-й массив в таблице на форме
                dataGridView1.Rows.Add(p.x, p.y);
        }
       
        private void btnDeleteCheckPoint_Click(object sender, EventArgs e)
        {
            try
            {
                //получаем номер выбранной строки
                int num = dataGridView1.SelectedRows[0].Index;
                //удаляем точку с данным номером из коллекции
                points.RemoveAt(num);
                //удаляем выбранную строку из таблицы
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
            }
            catch
            {
                MessageBox.Show("Выберите строку!!!");
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            //сортируем
            res.Sort();
            //очищаем содержимое таблицы на форме
            dataGridView2.Rows.Clear();
            foreach (Point p in res)
                //обновляем таблицу на форме
                dataGridView2.Rows.Add(p.x, p.y);
        }

        private void ex1_Load(object sender, EventArgs e)
        {
            points = new ArrayList(); //выделение памяти
            res = new ArrayList();
        }
    }
}
