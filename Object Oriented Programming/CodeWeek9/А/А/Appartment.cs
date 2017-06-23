using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace А
{
    public class Appartment : RealEstate<Room>, IShow, IArea
    {
        public Appartment(string Address)
            :  base(Address)
        {

        }   

        public override void Show()
        {
            Console.WriteLine("This is an Appartment");
            Console.WriteLine("Rooms: {0}", this.items.Count);
            Console.WriteLine("Area: {0}", this.Area);
            Console.WriteLine("--------ROOMS-------");
            foreach (Room item in items)
            {
               item.Show();
            }
        }
    }
}