using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace b
{
    class ThreadView
    {
        private static Nullable<int> asyncValue;

        public void Run()
        {
            Thread t = new Thread(new ThreadStart(GetAnswer));
            t.Start();

            for(int i=0;i<10;i++)
            {
                Thread.Sleep(500);
                if (asyncValue != null)
                    break;
            }

            Console.Clear();
            if (asyncValue == null)
                Console.WriteLine("Too slow");
            else
                Console.WriteLine(asyncValue.Value);

            Console.ReadKey(true);
        }

        private void GetAnswer()
        {
            Console.Write("2 + 2 = ");
            asyncValue = Convert.ToInt32(Console.ReadLine());
        }
    }
}
