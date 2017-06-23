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
            Car c = new Car();
            c.Make = "Zhigula";
            c.Model = "42";
            c.FuelType = FuelTypeEnum.Petrol;
            c.Milleage = 320000;
            c.Hps = 85;
            c.MarketPrice = 1000;
            c.Age = 22;

            PriceCalculator calc = new PriceCalculator();
            double currentPrice = calc.CalculatePrice(c);

            Console.WriteLine("Car - {0}, {1}, {2}km, {3}y/o, {4}BGN",
                                c.Make, c.Model, c.Milleage, c.Age, calc.CalculatePrice(c));

            Console.ReadKey(true);
        }
    }
}
