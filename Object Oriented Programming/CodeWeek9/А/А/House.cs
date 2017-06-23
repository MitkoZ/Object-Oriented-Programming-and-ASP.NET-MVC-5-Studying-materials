using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace А
{
    public class House : RealEstate<Room>, IShow, IArea
    {
        public House(string Address)
            :  base(Address)
        {

        }

        public override void Show()
        {
            Console.WriteLine("This is a House");
            Console.WriteLine("Rooms: {0}", this.items.Count);
            Console.WriteLine("Area: {0}", this.Area);
            Console.WriteLine("--------ROOMS-------");
            foreach (Room item in items)
                item.Show();
        }
    }
}
