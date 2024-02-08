using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1
{
    internal class Polynomial
    {
        float[] arr;
        public Polynomial(float[] arr)
        {
            this.arr = new float[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                this.arr[i] = arr[i];
                Console.WriteLine(arr[i]);
            }
        }

        public int SovleThePolynom(out float x1, out float x2)
        {
            x1 = 0;
            x2 = 0;
            double d = arr[1];
            return -1;
        }

        public void Sum(Polynomial term)
        {
            for(int i = 0;i < arr.Length;i++)
            {
                this.arr[i] += term.arr[i];
            }
        }
    }
}
