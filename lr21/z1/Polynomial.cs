using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1
{
    internal class Polynomial
    {
        public double[] arr;
        public Polynomial(float[] arr)
        {
            this.arr = new double[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                this.arr[i] = arr[i];
            }
        }

        public int SovleThePolynom(out double x1, out double x2)
        {
            double a, b, c;
            a = arr[2];
            b = arr[1];
            c = arr[0];
            x1 = 0;
            x2 = 0;
            double d = b*b-4*a*c;
            if (d<0)
                return -1;
            else
            {
                x1 = -b+Math.Sqrt(d) / (2 * arr[2]);
                x2 = -b-Math.Sqrt(d) / (2 * arr[2]);
                return 0;
            }
        }

        public void Sum(Polynomial pol1, Polynomial pol2)
        {
            for(int i = 0; i < pol2.arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
                this.arr[i] = pol1.arr[i] + pol2.arr[i];
            }
        }
    }
}
