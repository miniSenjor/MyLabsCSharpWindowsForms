using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        public string lName;
        public string address;
        public string phone;

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInput input = new FormInput();
            phone = address = lName = "";
            input.ShowDialog();
            if (input.lName!="")
            {
                string lName = input.lName, address = input.address, phone = input.phone;
                dataGridView1.Rows.Add(lName, address, phone);
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selected;
            try
            {
                selected = dataGridView1.SelectedRows[0].Index;
            }
            catch
            {
                selected = dataGridView1.SelectedCells[0].RowIndex;
            }
            dataGridView1.Rows.RemoveAt(selected);
        }

        string fName = "";

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            fName = openFileDialog1.FileName;
            string[] notes = File.ReadAllLines(fName);
            dataGridView1.Rows.Clear();
            foreach (string note in notes)
            {
                dataGridView1.Rows.Add(note.Split());
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            fName = saveFileDialog1.FileName;
            File.WriteAllText(fName, "");
            for (int i=0; i<dataGridView1.Rows.Count-1; i++)
            {
                string note = "";
                DataGridViewRow row = dataGridView1.Rows[i];
                //какая-то проблема с ячейками если введен с клавы, то не считывается
                foreach (DataGridViewCell cell in row.Cells)
                {
                    note += cell.Value.ToString() + " ";
                }
                File.AppendAllText(fName, note+"\r\n");
            }
        }

        private void поискToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSearch search = new FormSearch();
            search.ShowDialog();
            string lNameSearch = search.lName;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString() == lNameSearch)
                {
                    dataGridView1.Rows[row.Index].Selected = true;
                    return;
                }
            }
            MessageBox.Show("Объект не найден");
        }
    }
}
