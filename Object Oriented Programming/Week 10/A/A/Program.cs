using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A
{
    class Program
    {
        static void Test()
        {
            Console.WriteLine("This is a test!");
        }

        static int TestSum(int a, int b, int c)
        {
            return a + b + c;
        }

        static void Main(string[] args)
        {
            Test();

            //MyDelegate dlg = new MyDelegate(Test);
            Action dlg = new Action(Test);
            dlg();

            //MySumDelegate dlgSum = new MySumDelegate(TestSum);
            Func<int, int, int, int> dlgSum = new Func<int, int, int, int>(TestSum);
            int res = TestSum(3, 5, 8);
            Console.WriteLine("TestSum(3, 5, 9) = {0}", res);

            //Func<int, int, int> dlgMax = new Func<int, int, int>(aslfasdf);
            //Func<int, int, int> dlgMax = new Func<int, int, int>(
            //    delegate (int a, int b)
            //    {
            //        if (a > b)
            //            return a;
            //        else
            //            return b;
            // });
            Func<int, int, int> dlgMax = (a, b) => a > b ? a : b;

            Console.WriteLine("Max(5, 10) = {0}", dlgMax(5, 10));

            Console.ReadKey(true);
        }

        //public static int aslfasdf(int a, int b)
        //{
        //    if (a > b)
        //        return a;
        //    else
        //        return b;
        //}
    }
}
