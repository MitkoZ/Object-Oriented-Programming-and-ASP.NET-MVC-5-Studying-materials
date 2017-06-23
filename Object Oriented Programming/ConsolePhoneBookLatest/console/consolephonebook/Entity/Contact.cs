using System;

namespace ConsolePhonebook.Entity
{
    public class Contact : BaseEntity
    {
        public int ParentUserId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return this.FullName + " (" + this.Email + ")";
        }
    }
}
