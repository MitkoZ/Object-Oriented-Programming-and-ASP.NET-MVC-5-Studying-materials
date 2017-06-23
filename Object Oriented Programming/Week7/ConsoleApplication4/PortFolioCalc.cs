using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class RealEstatePortfolio
    {
        private List<RealEstate> items;
        private int price;

        public RealEstatePortfolio(List<RealEstate> items, int price)
        {
            this.items = items;
            this.price = price;
        }

        public int calculate()
        {
            int sum = 0;
            for (int i = 0; i < items.Count; i++)
            {
                sum += items[i].Area;
            }
            return sum+ price;
        }



        public void print()
        {
            Console.WriteLine("Stats...");
            Console.WriteLine("Count: "+items.Count);
            Console.WriteLine("Price per Smeter: " + price);
            Console.WriteLine("Total Price " + calculate());
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine("--------- {0} ---------", i + 1);
                string data = items[i].GetType().Name + ":    " + items[i].GetData();
                Console.WriteLine(data);


                //if (items[i] is House)
                //{
                //    House a = (House)items[i];

                //    Console.WriteLine("Type: House");
                //    Console.WriteLine("Area: " + a.Area);
                //    Console.WriteLine("Rooms: " + a.Rooms);
                //    Console.WriteLine("Floors: " + a.Floors);
                //}
                //else if(items[i] is Apartment)
                //{
                //    Apartment a = (Apartment)items[i];

                //    Console.WriteLine("Type: Apartment");
                //    Console.WriteLine("Area: " + a.Area);
                //    Console.WriteLine("Rooms: " + a.Rooms);
                //}

            }
        }
    }
}
