using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[5];
            shapes[0] = new Rectangle(10, 5);
            shapes[1] = new Square(10);
            shapes[2] = new Rectangle(20, 10);
            shapes[3] = new Rectangle(30, 10);
            shapes[4] = new Square(20);

            for (int i = 0; i < shapes.Length; i++)
            {
                Console.WriteLine("{0} has S:{1} and P:{2}",
                    shapes[i].ShapeType, shapes[i].S(), shapes[i].P());
            }

            Console.ReadKey(true);
        }
    }
}
