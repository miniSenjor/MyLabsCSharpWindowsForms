using System;
using System.Windows.Forms;

namespace lr19
{
    public partial class lr19 : Form
    {
        public lr19()
        {
            InitializeComponent();
        }

        struct Person
        {
            public string FIO;
            public int Distance;
        }

        Person[] mas;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtFIO.Text=="" || txtDistance.Text=="")
            {
                MessageBox.Show("Введите ФИО и расстояние до дома");
                return;
            }
            string fio = txtFIO.Text;
            int distance = int.Parse(txtDistance.Text);
            dataGridView1.Rows.Add(fio, distance);
            txtFIO.Clear();
            txtDistance.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.RowCount;
            mas = new Person[n];
            for (int i = 0; i < n; i++)
            {
                mas[i].FIO = (string)dataGridView1.Rows[i].Cells[0].Value;
                mas[i].Distance = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
            }
            Person stud;
            for (int i = 0;i < n-1; i++)
            {
                int maxI = i;
                int maxD = mas[i].Distance;
                for (int j = i+1;j<n-1;j++)
                {
                    if (mas[j].Distance>maxD)
                    {
                        maxI = j;
                        maxD = mas[j].Distance;
                    }
                }
                stud = mas[i];
                mas[i] = mas[maxI];
                mas[maxI] = stud;
            }
            int freePlaces = int.Parse(txtFreePlaces.Text);
            for (int i = 0;i<freePlaces;i++)
            {
                dataGridView2.Rows.Add(mas[i].FIO, mas[i].Distance);
            }
        }
    }
}
