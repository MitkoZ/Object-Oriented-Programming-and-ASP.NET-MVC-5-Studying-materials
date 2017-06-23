using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LockingThreads
{
    class Program
    {
        private static object key = new object();

        static void SampleMethod()
        {
            Console.WriteLine("Starting the Thread");

            lock (key)
            {
                Console.WriteLine("Fake processing start");
                Thread.Sleep(5000);
                Console.WriteLine("Fake processing end");
            }
            Console.WriteLine("Exit1");
        }

        static void SampleMethod1()
        {
            Console.WriteLine("Starting the Thread");

            lock (key)
            {
                Console.WriteLine("Fake processing start");
                Thread.Sleep(5000);
                Console.WriteLine("Fake processing end");
            }

            Console.WriteLine("Exit2");
        }

        static void Main(string[] args)
        {
            Thread t1 =
                new Thread(new ThreadStart(SampleMethod));
            Thread t2 =
                new Thread(new ThreadStart(SampleMethod1));

            t1.Start();
            t2.Start();

            Console.ReadKey(true);
        }
    }
}
