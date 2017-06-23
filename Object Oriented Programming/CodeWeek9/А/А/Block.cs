using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace А
{
    public class Block : RealEstate<Appartment>, IShow, IArea
    {
        public Block(string Address)
            : base(Address)
        {
        }

        public override void Show()
        {
            Console.WriteLine("This is a Block");
            Console.WriteLine("Rooms: {0}", this.items.Count);
            Console.WriteLine("Area: {0}", this.Area);
            Console.WriteLine("--------Appartments-------");
            foreach (Appartment item in items)
                item.Show();
        }
    }
}
