using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace G
{
    class Program
    {
        static void Test1()
        {
            Console.WriteLine("Test1 started");
            int counter = 0;
            for (int i = 0; i < 200000000; i++)
            {
                counter++;
            }
            Console.WriteLine("Test 1 - completed "+counter);
        }

        static void Test2()
        {
            Console.WriteLine("Test 2 started");
            uint counter = 0;
            for (uint i = 0; i < 400000000; i++)
            {
                counter++;
            }
            Console.WriteLine("Test 2 - completed " + counter);
        }
        static void Main(string[] args)
        {
            Thread t2 = new Thread(new ThreadStart(Test2));
            t2.Start();

            Thread t1 = new Thread(new ThreadStart(Test1));
            t1.Start();
            Console.WriteLine("Main reached the ReadKey!");
            Console.ReadKey(true);
        }
    }
}
