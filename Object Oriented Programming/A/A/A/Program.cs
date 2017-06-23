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
            //int a = 10;
            
            User u;
            u = new User();
            u.Username = "nikiv";
            u.Password = "nikipass";
            u.FirstName = "Nikola";
            u.LastName = "Valchanov";

            Console.WriteLine("{0} ({1})",
                u.FirstName + " " + u.LastName,
                u.Username);

            Console.ReadKey(true);
        }
    }
}
