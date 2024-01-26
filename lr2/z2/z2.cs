using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace z2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lstMenu.Items.Add("жаренные гвозди (10 руб)");
            lstMenu.Items.Add("мундиры (100 руб)");
            lstMenu.Items.Add("пицца 84 сыра (90 руб)");
            lstMenu.Items.Add("мясной кошмар (67 руб)");
            lstMenu.Items.Add("корндог (77 руб)");
            lstMenu.Items.Add("фритюрный кошмар (340 руб)");
            lstMenu.Items.Add("сычуанский соус (3 руб)");
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            lstZakaz.Items.Clear();
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
            float price=0;
            foreach (string item in lstZakaz.Items)
            {
                int start = item.IndexOf("(");
                string pr = item.Substring(start + 1);   
                int end = pr.IndexOf(" ");
                price += Convert.ToSingle(pr.Substring(0, end));
            }
            MessageBox.Show($"Приятного аппетита!\nС вас {price} рублей", "Ресторан \"Krang Pizza\"");
            this.Close();
        }

        private void btnAddMenu_Click(object sender, EventArgs e)
        {
            if (Regex.Matches(txtAdd.Text, @"\(\d+ руб\)").Count>0)
            lstMenu.Items.Add(txtAdd.Text);
        }

        
    }
}
