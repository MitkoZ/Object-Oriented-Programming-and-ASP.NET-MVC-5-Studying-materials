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
            Dog d = new Dog();
            Cat c = new Cat();
            Animal a = new Dog();

            Console.WriteLine("Cat sais: {0}", c.Speak());
            Console.WriteLine("Dog sais: {0}", d.Speak());
            Console.WriteLine("Animal sais: {0}", a.Speak());

            Animal[] arr = new Animal[5];
            arr[0] = new Cat();
            arr[1] = new Cat();
            arr[2] = new Dog();
            arr[3] = new Dog();
            arr[4] = new Cat();

            foreach(Animal animal in arr)
            {
                Console.WriteLine(animal.Speak());
            }

            Console.ReadKey(true);
        }
    }
}
