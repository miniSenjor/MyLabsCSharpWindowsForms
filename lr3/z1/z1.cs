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

        private void btnResult_Click(object sender, EventArgs e)
        {
            lstRes.Items.Clear();
            if (int.Parse(txtX1.Text) <= int.Parse(txtX2.Text) && int.Parse(txtY1.Text) <= int.Parse(txtY2.Text))
            {
                for (int x = int.Parse(txtX1.Text); x <= int.Parse(txtX2.Text); x++)
                    for (int y = int.Parse(txtY1.Text); y <= int.Parse(txtY2.Text); y++)
                    {
                        lstRes.Items.Add($"z(x,y) = {x} - {y} = {Z(x, y)}");
                    }
            }
            else MessageBox.Show("интервал должен быть от меньшего к большему");
        }

        private int Z(int x, int y)
        {
            return x - y;
        }
    }
}
