using System;
using System.Drawing;
using System.Windows.Forms;

namespace lr9z1
{
    public partial class z1 : Form
    {
        public z1()
        {
            InitializeComponent();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            // создаем переменную fname строкового типа
            string fname;
            // открываем Проводник
            if (file1.ShowDialog() == DialogResult.OK)
            {
                // используем переменную для хранения имени выбранного файла
                fname = file1.FileName;
                // загружаем файл в элемент PictureBox
                pct.Image = Image.FromFile(fname);
                txtIm.Text = fname;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            file1.Filter = "(*.jpg)|*.jpg";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtIm.Text != "")
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    pct.Image.Save(saveFileDialog1.FileName);
            }
        }
    }
}
