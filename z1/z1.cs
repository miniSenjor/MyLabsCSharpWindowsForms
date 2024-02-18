using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        List<Letters> letters = new List<Letters>();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int type;
            if (rB1.Checked)
                type = 1;
            else if (rB2.Checked)
                type = 2;
            else
                 type = 3;

            Letters newLetter = new Letters(type, txtFrom.Text, txtTo.Text);
            letters.Add(newLetter);
            txtLettters.Text += newLetter.type;
            txtFrom.Text = "";
            txtTo.Text = "";
        }
    }

    class EnterpriseDocument
    {
        int _type;
        public EnterpriseDocument(int type)
        {
            this._type = type;
        }

        public int type
        {
            get { return _type; }
            set { _type = value; }
        }
    }

    class Correspondent
    {
        string _fio;
        public Correspondent( string fio )
        {
            this._fio = fio;
        }

        public string fio
        {
            get { return _fio; }
            set { _fio = value; }
        }
    }

    class Letters : EnterpriseDocument
    {
        string from;
        string to;

        public Letters(int type, string from, string to):
        base(type)
        {
            this.from = from;
            this.to = to;
        }

        public 
    }
}
