using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B
{
    public class Square : Shape
    {
        public int A { get; private set; }

        public Square(int A)
        {
            ShapeType = "Square";
            this.A = A;
        }

        public override int S()
        {
            return A * A;
        }

        public override int P()
        {
            return A * 4;
        }
    }
}
