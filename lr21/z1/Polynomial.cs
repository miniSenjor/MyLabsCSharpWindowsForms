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
        public Polynomial(params float[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                this.arr[i] = arr[i];
            }
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
