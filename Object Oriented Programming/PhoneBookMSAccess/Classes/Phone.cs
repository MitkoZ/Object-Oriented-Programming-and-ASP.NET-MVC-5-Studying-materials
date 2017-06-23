using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook.Classes
{
    public class Phone
    {
        public Int32 ID { get; set; }
        public Int32 ContactID { get; set; }
        public String PhoneNumber { get; set; }

        public override string ToString()
        {
            return this.PhoneNumber;
        }
    }
}
