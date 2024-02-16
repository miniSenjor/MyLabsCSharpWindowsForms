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

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }

    class EnterpriseDocument
    {
        string name;
        public EnterpriseDocument(string name )
        {
            this.name = name;
        }
    }

    class Correspondent
    {

    }

    class Letters : EnterpriseDocument
    {
        string from;
        string to;

        public Letters(string name, string from, string to):
        base(name)
        {
            this.from = from;
            this.to = to;
        }
    }
}
