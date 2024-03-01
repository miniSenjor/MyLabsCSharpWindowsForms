using System;
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
            lbRates.Items.Clear();
            DateTime minSelectedDate = monthCalendar1.SelectionRange.Start;
            DateTime maxSelectedDate = monthCalendar1.SelectionRange.End;
            Console.WriteLine(maxSelectedDate);
            for (int i=0; i<rates.Length; i+=2)
            {
                if (Convert.ToDateTime(rates[i])>=minSelectedDate && Convert.ToDateTime(rates[i])<=maxSelectedDate)
                    lbRates.Items.Add(rates[i] + " " + rates[i+1]);
                
                if (Convert.ToDateTime(rates[i]) > maxSelectedDate)
                    break;
            }
        }
    }
}