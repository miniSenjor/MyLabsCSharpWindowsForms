using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace z1
{
    public partial class z1 : Form
    {
        public z1()
        {
            InitializeComponent();
        }

        private void btnWriteRates_Click(object sender, EventArgs e)
        {
            string[] rates = File.ReadAllLines("D://ProgramC#//GitHub//MyLabsCSharpWindowsForms//lr30//z1//txt.txt");
            List<string> selectedDates = new List<string>();
            selectedDates.AddRange(monthCalendar1.SelectionRange)
        }
    }
}
