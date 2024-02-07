using System;
using System.Windows.Forms;

namespace ex1
{
    public partial class ex1 : Form
    {
        public ex1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Введите имя");
                return;
            }
            Person new_person;
            if (txtAge.Text != "")
            {
                if (txtProfession.Text != "")
                {
                    try { new_person = new Person(txtName.Text, Convert.ToInt32(txtAge.Text), txtProfession.Text); }
                    catch 
                    { 
                        MessageBox.Show("Некоректный возраст");
                        return;
                    }
                }
                else
                {
                    new_person = new Person(txtName.Text, Convert.ToInt32(txtAge.Text));
                }
            }
            else
            {
                if (txtProfession.Text != "")
                {
                    new_person = new Person(txtName.Text, 0, txtProfession.Text);
                }
                else
                {
                    new_person = new Person(txtName.Text);
                }
            }

            txtResult.Text += new_person.GetInformation();
        }
    }
}
