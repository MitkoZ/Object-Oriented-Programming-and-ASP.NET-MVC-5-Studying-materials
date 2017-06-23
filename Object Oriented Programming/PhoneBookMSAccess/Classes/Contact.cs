using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook.Classes
{
    public class Contact
    {
        public Int32 ID { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public List<Phone> Phones { get; set; }

        public override String ToString()
        {
            return this.FirstName + " " + this.LastName;
        }
    }
}
