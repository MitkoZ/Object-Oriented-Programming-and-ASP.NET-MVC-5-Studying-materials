using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class RealEstate
    {
        public int Area { get; set; }
        public virtual string GetData()
        {
            return "Area: " + Area;
        }
    }
}
