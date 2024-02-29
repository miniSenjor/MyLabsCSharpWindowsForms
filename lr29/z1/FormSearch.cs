using System;
using System.Windows.Forms;

namespace z1
{
    public partial class FormSearch : Form
    {
        public FormSearch()
        {
            InitializeComponent();
        }

        public string lName;

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtLName.Text != "")
            {
                lName = txtLName.Text;
                Close();
            }
        }
    }
}
