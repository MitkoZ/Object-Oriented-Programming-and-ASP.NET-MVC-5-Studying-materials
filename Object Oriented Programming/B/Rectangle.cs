using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B
{
    class Rectangle
    {
        int a;
        int b;

        public int A
        {
            get
            {
                return a;
            }
        }

        public Rectangle(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public int S()
        {
            return a * b;
        }

        public int P()
        {
            return a * 2 + b * 2;
        }
    }
}
