using System;
using System.Windows.Forms;

namespace lr18
{
    public partial class lr18 : Form
    {
        public lr18()
        {
            InitializeComponent();
        }

        private void btnMakeName_Click(object sender, EventArgs e)
        {
            if (txtLetters.Text=="" || txtName.Text=="")
            {
                MessageBox.Show("Введите стрроку и имя!");
                label3.Text = "Составить имя ...";
                return;
            }
            string name = txtName.Text;
            string letters = txtLetters.Text;
            bool isMakeName = true;
            if (checkRepeatLetters.Checked)
            {
                for (int i = 0; i<name.Length; i++)
                {
                    if (letters.IndexOf(name[i])==-1)
                    {
                        isMakeName = false;
                        break;
                    }
                }
            }
            else
            {
                char[] chars = letters.ToCharArray();
                Array.Sort(chars);
                int startIndex = 0;
                for (int i = 0; i < name.Length; i++)
                {
                    startIndex = letters.IndexOf(name[i],startIndex);
                    if (startIndex == -1)
                    {
                        isMakeName = false;
                        break;
                    }
                }
            }
            if (isMakeName) label3.Text = "Составить имя можно";
            else label3.Text = "Составить имя нельзя";
        }
    }
}
