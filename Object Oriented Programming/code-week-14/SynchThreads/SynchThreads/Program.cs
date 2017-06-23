using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SynchThreads
{
    class Program
    {
        public static Thread T1;
        public static Thread T2;
        //This AutoResetEvent starts out non-signalled
        public static AutoResetEvent ar1 = new AutoResetEvent(false);
        //This AutoResetEvent starts out signalled
        public static AutoResetEvent ar2 = new AutoResetEvent(true);

        static void Main(string[] args)
        {
            T1 = new Thread((ThreadStart)delegate
                {
                    Console.WriteLine(
                        "T1 is simulating some work by sleeping for 5 secs");
                    //calling sleep to simulate some work
                    Thread.Sleep(5000);
                    Console.WriteLine(
                        "T1 is just about to set AutoResetEvent ar1");
                    //alert waiting thread(s)
                    ar1.Set();
                });

            T2 = new Thread((ThreadStart)delegate
            {
                //wait for AutoResetEvent ar1, this will wait for ar1 to be signalled
                //from some other thread
                Console.WriteLine(
                    "T2 starting to wait for AutoResetEvent ar1, at time {0}",
                    DateTime.Now.ToLongTimeString());
                ar1.WaitOne();
                Console.WriteLine(
                    "T2 finished waiting for AutoResetEvent ar1, at time {0}",
                    DateTime.Now.ToLongTimeString());

                //wait for AutoResetEvent ar2, this will skip straight through
                //as AutoResetEvent ar2 started out in the signalled state
                Console.WriteLine(
                    "T2 starting to wait for AutoResetEvent ar2, at time {0}",
                    DateTime.Now.ToLongTimeString());
                ar2.WaitOne();
                Console.WriteLine(
                    "T2 finished waiting for AutoResetEvent ar2, at time {0}",
                    DateTime.Now.ToLongTimeString());
            });

            T1.Name = "T1";
            T2.Name = "T2";
            T1.Start();
            T2.Start();
            Console.ReadKey(true);
        }
    }
}
