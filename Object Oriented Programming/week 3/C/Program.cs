using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C
{
    class Program
    {
        static void Main(string[] args)
        {
            Square s = new Square(10);

            Console.WriteLine("Square A:{0}, S:{1}, P:{2}", s.A, s.S(), s.P());

            Console.ReadKey(true);
        }
    }
}
