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

namespace lr17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnTest_Click(object sender, EventArgs e)
        {
            Hide();
            Test test = new Test();
            test.ShowDialog();

            Show();
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            if (File.Exists("Result.txt"))
            {
                btnOk.Visible = true;
                listBox1.Visible = true;
                using (StreamReader sr = File.OpenText("Result.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        listBox1.Items.Add(line);
                    }
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            listBox1.Items.Clear();
            btnOk.Visible = false;
        }
    }
}
