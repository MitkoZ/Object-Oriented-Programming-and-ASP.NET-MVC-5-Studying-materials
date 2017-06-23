using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace А
{
    public class Room : IShow, IArea
    {
        public int Area { get; private set; }

        public Room(int Area)
        {
            this.Area = Area;
        }

        public void Show()
        {
            Console.WriteLine("Room");
            Console.WriteLine("Area: {0}", this.Area);
        }
    }
}
