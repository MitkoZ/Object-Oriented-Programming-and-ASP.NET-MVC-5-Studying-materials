using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //broi na propertyta
            // class name i ime
            //imena na propertita i tehnite tipove
            User u = new ConsoleApplication2.User();
            u.FirstName = "Ivan";
            u.LastName = "Ivanov";
            u.Password = "123456";
            u.Username = "Pesho";
            object o = u;
            Type t = o.GetType();
            Console.WriteLine(t);
            Console.WriteLine(t.GetProperties().Length);
            Console.WriteLine("----------------------");
           
            foreach (PropertyInfo item in t.GetProperties())
            {
                Console.WriteLine(item.PropertyType);
                Console.WriteLine(item.Name);
                Console.WriteLine(item.GetValue(o));
                Console.WriteLine("---------------------");
            }
            //PropertyInfo pi = t.GetProperty("FirstName");

            PropertyInfo pi = t.GetProperty("FirstName");
            pi.SetValue(o, "changed");


            foreach (PropertyInfo item in t.GetProperties())
            {
                Console.WriteLine(item.PropertyType);
                Console.WriteLine(item.Name);
                Console.WriteLine(item.GetValue(o));
                Console.WriteLine("---------------------");
            }
            Console.ReadKey(true);
        }
    }
}
