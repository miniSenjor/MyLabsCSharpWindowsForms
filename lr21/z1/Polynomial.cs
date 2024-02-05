using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1
{
    internal class Polynomial
    {
        float a, b, c;
        public Polynomial(float a, float b, float c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void Sum(Polynomial term)
        {
            this.a += term.a;
            this.b += term.b;
            this.c += term.c;
        }
    }
}
