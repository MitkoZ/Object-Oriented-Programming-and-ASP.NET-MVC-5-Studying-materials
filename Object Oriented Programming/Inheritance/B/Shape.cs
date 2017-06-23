using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B
{
    public class Shape
    {
        public string ShapeType { get; protected set; }

        public Shape()
        {
            ShapeType = "Shape";
        }

        public virtual int S()
        {
            throw new NotImplementedException();
        }

        public virtual int P()
        {
            throw new NotImplementedException();
        }
    }
}
