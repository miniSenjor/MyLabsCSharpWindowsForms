using System;

namespace z1
{
    internal class Polynomial
    {
        public double[] arr;
        public Polynomial(double[] arr)
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
                this.arr[i] = pol1.arr[i] + pol2.arr[i];
            }
        }

        public void Subtract(Polynomial pol1, Polynomial pol2)
        {
            for (int i = 0; i < pol2.arr.Length; i++)
            {
                this.arr[i] = pol1.arr[i] - pol2.arr[i];
            }
        }

        public Polynomial Multiply(Polynomial pol1, Polynomial pol2)
        {
            int lengthRes = 3;
            if (pol1.arr[2] != 0) lengthRes++;
            if (pol2.arr[2] != 0) lengthRes++;
            double[] arr = new double[lengthRes];
            Polynomial resPol = new Polynomial(arr);
            resPol.arr[0] = pol1.arr[0] * pol2.arr[0];
            resPol.arr[1] = pol1.arr[1] * pol2.arr[0] + pol1.arr[0] * pol2.arr[1];
            resPol.arr[2] = pol1.arr[1] * pol2.arr[1] + pol1.arr[0] * pol2.arr[2] + pol1.arr[2] * pol2.arr[0];
            if (lengthRes > 3) resPol.arr[3] = pol1.arr[1] * pol2.arr[2] + pol1.arr[2] * pol2.arr[1];
            if (lengthRes > 4) resPol.arr[4] = pol1.arr[2] * pol2.arr[2];
            return resPol;
        }
    }
}
