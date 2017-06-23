using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B
{
    public class Rectangle
    {
        private int a;
        public int A
        {
            get
            {
                return a;
            }
        }
        private int b;
        public int B
        {
            get
            {
                return b;
            }
        }
        public Rectangle(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public int S()
        {
            return a * a;
        }

        public int P()
        {
            return (a + b) * 2;
        }
    }
}
