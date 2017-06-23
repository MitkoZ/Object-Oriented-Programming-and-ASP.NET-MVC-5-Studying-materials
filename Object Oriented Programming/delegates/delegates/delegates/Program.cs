using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace delegates
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
        static int BiggestNumber(int a, int b)
        {
            if (a>b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        static void Main(string[] args)
        {
            Test();
            //MyDelegate dlg = new MyDelegate(Test);
            //dlg();
            //vrashta cqlo 4islo i priemat 2 celi 4isla
            //statichna funkciq koqto vrashta po golqmata ot 2 celi 4isla (5,10) prez sazdadeniq delegat
            //MySumDelegate dlgSum = new MySumDelegate(TestSum);
            //int res=TestSum(3, 5, 8);
            //Console.WriteLine("Test(3,5,8)={0}",res);
            
            MyNum biggestNum = new MyNum(BiggestNumber);
            int res = biggestNum(5, 10);
            Console.WriteLine(res);
            Action dlg = new Action(Test);
            //Func<int,int,int,int> dlgSum = new Func<int, int, int, int>(TestSum);
            //Func<int, int, int> mul = new Func<int, int, int>(
            //    delegate(int a,int b) 
            //    {
            //        return a * b;
            //    });
            Func<int, int, int> mul = (a, b) => a * b;
            Console.WriteLine("mul(10, 20)={0}",mul(10,20));
            Console.ReadKey(true);

            //prilojenie defenirane klas user-username password
            //main List<Useri>
            //3 usera v lista
            // read username i password
            //if user exist cw if user doesn't uxist
            //user.find metod find chaka delegat kam funkciq koqto proverqva dali ima element v taq kolekciq koqto otgovarq na uslovieto (list.find)
        }
    }
}
