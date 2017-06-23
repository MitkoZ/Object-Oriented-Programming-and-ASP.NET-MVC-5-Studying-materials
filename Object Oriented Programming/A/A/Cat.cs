using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A
{
    class Cat
    {
        public int weight;
        public string color;

        public string Speak()
        {
            if (weight > 20)
                return "MEW";
            else
                return "mew";
        }
    }
}
