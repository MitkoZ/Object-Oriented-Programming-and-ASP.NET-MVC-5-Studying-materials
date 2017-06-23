using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace H
{
    class Program
    {
        static string result = null;
        static void AsyncReadLine()
        {
            result = Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("2 + 2 = ");
            Thread t = new Thread(new ThreadStart(AsyncReadLine));
            //Thread t = new Thread(delegate () { AsyncReadLine(); });
            //Thread t = new Thread(()=>AsyncReadLine());
            //nishki
            t.Start();
            for (int i = 0; i < 50; i++)
            {
                Thread.Sleep(100);
                if (result!=null)
                {
                    break;
                }
            }
            Console.Clear();
            if (result == null)
            {
                Console.WriteLine("Your time is up!");
            }
            else if(result=="4")
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Wrong!");
            }
            Console.ReadKey(true);
        }
    }
}
