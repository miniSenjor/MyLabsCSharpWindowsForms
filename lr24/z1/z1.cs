using System;
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
            double[] a = new double[21];
            int[] b;
            if (random.Next(2)==0)
            {
                b = new int[random.Next(22, 27)];
            }
            else
            {
                b = new int[random.Next(15, 21)];
            }

            if (a.Length > b.Length) 
            {
                int lengthB = b.Length;
                for (int i = 0; i<a.Length; i++)
                {
                    CalcA(i, a);
                    if(lengthB > 0)
                    {
                        CalcB(i, b, random);
                        lengthB--;
                    }
                    CalcC(i, a, b);
                    
                }
            }
            else
            {
                int lengthA = a.Length;
                for (int i = 0; i < b.Length; i++)
                {
                    CalcB(i, b, random);
                    if(lengthA > 0)
                    {
                        CalcA(i, a);
                        lengthA--;
                    }
                    CalcC(i, a, b);
                }
            }
        }

        void CalcA(int i, double[] a)
        {
            try
            {
                double x = -2;
                x = x + 0.3 * i;
                if (x - 1 <= 0)
                    throw new ArgumentOutOfRangeException("x");
                x = Math.Log10(1 / (x - 1));
                a[i] = x;
            }
            catch
            {
                a[i] = 0;
            }
            lbA.Items.Add(a[i]);
        }

        void CalcB(int i, int[] b, Random random)
        {
            b[i] = random.Next(21) - 10;
            lbB.Items.Add(b[i]);
        }

        void CalcC(int i, double[] a, int[] b)
        {
            double c = 0;
            try
            {
                if (a[i] < b[i - 1])
                    throw new ArgumentOutOfRangeException("a<b");
                c = Math.Sqrt(a[i] - b[i - 1]);
                lbC.Items.Add(c);
            }
            catch (IndexOutOfRangeException)
            {
                lbC.Items.Add("Вне границ массива");
            }
            catch (ArgumentOutOfRangeException)
            {
                lbC.Items.Add("корень из отрицательного числа");
            }
        }
    }
}
