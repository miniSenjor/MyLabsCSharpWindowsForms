using System;
using System.Windows.Forms;

namespace z1
{
    public partial class FormInput : Form
    {
        public string lName="";
        public string address;
        public string phone;
        public FormInput()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtLName.Text!="" && txtAddress.Text!="" && txtMaskedPhone.Text!="")
            {
                lName = txtLName.Text;
                address = txtAddress.Text;
                phone = txtMaskedPhone.Text;
            }
            Close();
        }
    }
}
