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

        private void btnStart_Click(object sender, EventArgs e)
        {
            lbA.Items.Clear();
            lbB.Items.Clear();
            lbC.Items.Clear();
            Random random = new Random();
            double[] a = new double[21], b;
            if (random.Next(2)==0)
            {
                b = new double[random.Next(22, 27)];
            }
            else
            {
                b = new double[random.Next(15, 21)];
            }

            if (a.Length > b.Length) 
            {
                int lengthB = b.Length;
                for (int i = 0; i<a.Length; i++)
                {
                    try
                    {
                        double y = - 2;
                        y = y + 0.3 * i;
                        y = Math.Log10(1 / (y - 1));
                        a[i] = y;
                        //a[i] = Math.Log10(1/(i-2+0.3*i)-1);
                    }
                    catch 
                    {
                        a[i] = 0;
                    }
                    lbA.Items.Add(a[i]);
                    if(lengthB > 0)
                    {
                        b[i] = random.Next(21) - 10;
                        lbB.Items.Add(b[i]);
                        lengthB--;
                    }

                    double c=0;
                    try
                    {
                        c = Math.Sqrt(a[i]-b[i-1]);
                        lbC.Items.Add(c);
                    }
                    catch (IndexOutOfRangeException) 
                    {
                        lbC.Items.Add("Вне границ массива");
                    }
                    //catch ()
                }
            }
            else
            {
                int lengthA = a.Length;
                for (int i = 0; i < b.Length; i++)
                {
                    b[i] = random.Next(21) - 10;
                    lbB.Items.Add(b[i]);
                    if(lengthA > 0)
                    {
                        try
                        {
                            a[i] = Math.Log10(1 / (i - 2 + 0.3 * i) - 1);
                        }
                        catch
                        {
                            a[i] = 0;
                        }
                        lbA.Items.Add(a[i]);
                        lengthA--;
                    }
                }
            }
        }

        double Fun(double x)
        {
            return Math.Log10(1/x-1);
        }
    }
}
