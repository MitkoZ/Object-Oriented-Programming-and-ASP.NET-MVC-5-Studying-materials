using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace А
{
    public class PriceCalculator
    {
        public double CalculatePrice(Car c)
        {
            double price = c.MarketPrice;

            if (c.Age > 10)
                price -= price * 0.6;
            else if (c.Age > 5)
                price -= price * 0.3;
            else if (c.Age > 1)
                price -= price * 0.2;

            if (c.Milleage > 200000)
                price -= price * 0.3;
            else if (c.Milleage > 100000)
                price -= price * 0.15;
            else if (c.Milleage > 30000)
                price -= price * 0.1;

            return price;
        }
    }
}
