using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace c
{
    public class Timer
    {
        private Thread t = null;
        public int timeout = 0;
        public bool Enabled { get; set; }

        public Action Tick;
        
        private void RunThread()
        {
            while(true)
            {
                Thread.Sleep(timeout);

                if (Enabled)
                    Tick();
            }
        }

        public void Start()
        {
            t = new Thread(RunThread);
            t.Start();
        }

        public void Stop()
        {
            if (t != null)
                t.Abort();

            t = null;
        }
    }
}
