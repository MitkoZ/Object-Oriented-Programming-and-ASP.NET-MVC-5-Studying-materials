using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();

            User u = new User();
            u.Username = "user1";
            u.Password = "1pass";
            list.Add(u);

            u = new User();
            u.Username = "user2";
            u.Password = "2pass";
            list.Add(u);

            u = new User();
            u.Username = "user3";
            u.Password = "3pass";
            list.Add(u);
            
            for(int i=0;i<3;i++)
            {
                User temp = list.GetItemAt(i);
                Console.WriteLine("{0} ({1})", temp.Username, temp.Password);
            }

            Console.ReadKey(true);
        }
    }
}
