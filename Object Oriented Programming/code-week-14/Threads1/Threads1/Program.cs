using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threads1
{
    class Program
    {
        static void MyMethod()
        {
            Console.WriteLine("MyMethod executed");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Main started");

            ThreadStart dlg = new ThreadStart(MyMethod);
            Thread thread = new Thread(dlg);
            thread.Start();

            Thread.Sleep(3000);

            Console.WriteLine("Main finished");
            Console.ReadKey(true);
        }
    }
}
