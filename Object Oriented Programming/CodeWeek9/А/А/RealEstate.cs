using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace А
{
    public abstract class RealEstate<T> where
        T : IShow, IArea
    {
        protected List<T> items { get; set; }

        public string Address { get; private set; }

        public int Area
        {
            get
            {
                int sum = 0;
                foreach (T r in items)
                    sum += r.Area;

                return sum;
            }
        }

        public RealEstate(string Address)
        {
            this.items = new List<T>();
            this.Address = Address;
        }

        public void Add(T item)
        {
            this.items.Add(item);
        }

        public abstract void Show();
    }
}
