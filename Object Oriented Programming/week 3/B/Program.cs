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
            
            Console.WriteLine("a:{0} b:{1}, S {2}, P {3}", rect.A, rect.B, rect.S(), rect.P());

            Console.ReadKey(true);
        }
    }
}
