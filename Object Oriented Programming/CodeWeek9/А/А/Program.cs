using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace А
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IShow> items = new List<IShow>();

            House house = new House("Gagarin 12");
            house.Add(new Room(15));
            house.Add(new Room(10));
            house.Add(new Room(20));
            items.Add(house);

            house = new House("Gagarin 14");
            house.Add(new Room(15));
            house.Add(new Room(30));
            items.Add(house);

            Block block = new Block("Gagarin 13");
            Appartment appartment = new Appartment("Gagarin 13");
            appartment.Add(new Room(15));
            appartment.Add(new Room(30));
            block.Add(appartment);

            appartment = new Appartment("Gagarin 13");
            appartment.Add(new Room(45));
            block.Add(appartment);
            items.Add(block);
            foreach (IShow h in items)
            {
                h.Show();
            }
            Room room = new Room(5);
            Console.ReadKey(true);
        }
    }
}
