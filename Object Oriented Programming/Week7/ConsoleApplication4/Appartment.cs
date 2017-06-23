using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Apartment : RealEstate
    {
        public int Rooms { get; set; }
        public override string GetData()
        {
            return base.GetData() + ", Rooms: " + Rooms;
        }
    }
}
