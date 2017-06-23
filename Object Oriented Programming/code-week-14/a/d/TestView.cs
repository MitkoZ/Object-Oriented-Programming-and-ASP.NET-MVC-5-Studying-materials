using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace c
{
    public class TestView
    {
        private int value = 0;
        private void WriteNext()
        {
            Console.WriteLine(value++);
        }

        public void Run()
        {
            Timer t = new Timer();
            t.timeout = 1000;
            t.Enabled = true;
            t.Tick = new Action(WriteNext);
            t.Start();

            while (true)
            {
                ConsoleKeyInfo ki = Console.ReadKey(true);
                if (ki.Key == ConsoleKey.X)
                    break;

                if (t.Enabled == true)
                    t.Enabled = false;
                else
                    t.Enabled = true;
            }

            t.Stop();
        }
    }
}
