using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B
{
    public class Rectangle : Square
    {
        public int B { get; private set; }

        public Rectangle(int A, int B) : base(A)
        {
            ShapeType = "Rectangle";
            this.B = B;
        }

        public override int S()
        {
            return A * B;
        }

        public override int P()
        {
            return A * 2 + B * 2;
        }
    }
}
