using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace c
{
    class TestView
    {
        private int value = 0;
        private void WriteNext()
        {
            Console.WriteLine(value++);
        }

        private void Timer()
        {
            while (true)
            {
                Thread.Sleep(1000);
                WriteNext();
            }
        }

        public void Run()
        {
            Thread t = new Thread(Timer);
            t.Start();

            while (true)
            {
                ConsoleKeyInfo ki = Console.ReadKey(true);
                if (ki.Key == ConsoleKey.X)
                    break;

                if (t.ThreadState == ThreadState.Suspended)
                    t.Resume();
                else
                    t.Suspend();
            }

            t.Abort();
        }


    }
}
