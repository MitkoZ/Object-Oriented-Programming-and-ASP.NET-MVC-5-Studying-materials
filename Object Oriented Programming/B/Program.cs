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
            Rectangle rect = new Rectangle(10, 5);
            Rectangle rect1 = new Rectangle(15, 10);

            Console.WriteLine(rect.A);
            
            Console.WriteLine(
                "The Rect has S = {0} and P = {1}",
                rect.S(), rect.P());

            Console.WriteLine(
                "The Rect1 has S = {0} and P = {1}",
                rect1.S(), rect1.P());

            Console.ReadKey(true);
        }
    }
}
