using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.color = "black";
            cat.weight = 25;

            Console.WriteLine(
                "The {0} cat weighs {1}kg and sais {2}",
                cat.color, cat.weight, cat.Speak()
            );

            Console.ReadKey(true);
        }
    }
}
