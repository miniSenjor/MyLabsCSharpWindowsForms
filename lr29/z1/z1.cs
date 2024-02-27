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
            if (fName == "")
            {
                MessageBox.Show("Файл не выбран");
                return;
            }

            string[] notes = new string[0];
            Console.WriteLine(dataGridView1.Rows.Count);
            Console.WriteLine(dataGridView1.Rows[0].Cells.Count);
            for (int i=0; i<dataGridView1.Rows.Count; i++)
            {
                string note = "";
                DataGridViewRow row = dataGridView1.Rows[i];
                for (int j=0; j<dataGridView1.Rows[i].Cells.Count-1;j++)
                {
                    note += dataGridView1.Rows[i].Cells[j].Value.ToString() + " ";
                }
                notes.Append(note);
            }
            File.WriteAllLines(fName, notes);
        }
    }
}
