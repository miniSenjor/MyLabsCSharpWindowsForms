using System;
using System.Collections.Generic;
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
        List<Correspondent> correspondents = new List<Correspondent>();
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
            Correspondent correspondent = new Correspondent(txtFrom.Text);
            if (!correspondents.Contains(correspondent))
                correspondents.Add(correspondent);
            
            letters.Add(newLetter);
            txtLettters.Text += $"Тип №{newLetter.type} Кому: {newLetter.to} От кого: {newLetter.from}\r\n";
            txtFrom.Text = "";
            txtTo.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            letters = new List<Letters>();
            correspondents = new List<Correspondent>();
            txtLettters.Text = "";
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
        string _from;
        string _to;

        public Letters(int type, string from, string to):
        base(type)
        {
            this._from = from;
            this._to = to;
        }
        public string from
        {
            get { return _from; }
            set { _from = value; }
        }
        public string to
        {
            get { return _to; }
            set { _to = value; }
        }
    }
}
