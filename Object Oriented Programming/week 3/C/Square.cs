using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C
{
    public class Square
    {
        public int A { get; private set; }

        public Square(int a)
        {
            A = a;
        }

        public int S()
        {
            return A * A;
        }

        public int P()
        {
            return A * 4;
        }
    }
}
