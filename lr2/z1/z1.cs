using System;
using System.Windows.Forms;

namespace z1
{
    public partial class z1 : Form
    {
        public z1()
        {
            InitializeComponent();
            lstMenu.Items.Add("жаренные гвозди");
            lstMenu.Items.Add("мундиры");
            lstMenu.Items.Add("пицца 84 сыра");
            lstMenu.Items.Add("мясной кошмар");
            lstMenu.Items.Add("корндог");
            lstMenu.Items.Add("фритюрный кошмар");
            lstMenu.Items.Add("сычуанский соус");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstZakaz.Items.Add(lstMenu.Text);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lstZakaz.Items.Remove(lstZakaz.SelectedItem);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Приятного аппетита!", "Ресторан \"Krang Pizza\"");
            this.Close();
        }
    }
}
