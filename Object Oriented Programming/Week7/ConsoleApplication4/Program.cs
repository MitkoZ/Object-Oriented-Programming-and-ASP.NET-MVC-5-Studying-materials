using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Something....");
            Console.WriteLine();
            List<RealEstate> items = new List<RealEstate>();
            int price = 5;
            items.Add(new House()
            {
                Floors = 3,
                Rooms = 12,
                Area = 300
            });
            items.Add(new House()
            {
                Floors = 2,
                Rooms = 6,
                Area = 150
            });
            items.Add(new Apartment()
            {
                Rooms = 3,
                Area = 140
            });
            items.Add(new Apartment()
            {
                Rooms = 5,
                Area = 200
            });
            items.Add(new Apartment()
            {
                Rooms = 2,
                Area = 80
            });

            RealEstatePortfolio calc = new RealEstatePortfolio(items, price);
            calc.print();
            Console.ReadKey(true);
        }
    }
}
