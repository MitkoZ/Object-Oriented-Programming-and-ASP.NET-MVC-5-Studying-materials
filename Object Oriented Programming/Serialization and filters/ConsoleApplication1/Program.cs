using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            User u = new ConsoleApplication1.User();
            u.Id = 1;
            u.FirstName = "Nikola";
            u.LastName = "Valchanov";
            u.Username = "nikiv";
            u.Password = "nikipass";
            FileStream fs = new FileStream("test.txt", FileMode.OpenOrCreate);

            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, u);
            fs.Close();
            FileStream fso = new FileStream("test.txt", FileMode.Open);
            User u1=(User)bf.Deserialize(fso);
            Console.WriteLine(u1.Username);
            Console.ReadKey(true);

            //domashno 
            //sashtoto otgore obache napraveno s XmlSerializer
        }
    }
}
