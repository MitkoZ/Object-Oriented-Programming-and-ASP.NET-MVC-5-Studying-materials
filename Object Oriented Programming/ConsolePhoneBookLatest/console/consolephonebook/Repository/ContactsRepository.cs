using ConsolePhonebook.Entity;
using System;
using System.Collections.Generic;
using System.IO;

namespace ConsolePhonebook.Repository
{
    public class ContactsRepository : BaseRepository<Contact>
    {
        public ContactsRepository(string filePath) : base(filePath)
        { }
        protected override void PopulateEntity(StreamReader sr, Contact item)
        {
            item.Id = Convert.ToInt32(sr.ReadLine());
            item.ParentUserId = Convert.ToInt32(sr.ReadLine());
            item.FullName = sr.ReadLine();
            item.Email = sr.ReadLine();
        }

        protected override void WriteEntity(StreamWriter sw, Contact item)
        {
            sw.WriteLine(item.Id);
            sw.WriteLine(item.ParentUserId);
            sw.WriteLine(item.FullName);
            sw.WriteLine(item.Email);
        }
        public List<Contact> GetAll(int parentUserId)
        {
            List<Contact> result = new List<Contact>();

            FileStream fs = new FileStream(this.filePath, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);

            try
            {
                while (!sr.EndOfStream)
                {
                    Contact contact = new Contact();
                    contact.Id = Convert.ToInt32(sr.ReadLine());
                    contact.ParentUserId = Convert.ToInt32(sr.ReadLine());
                    contact.FullName = sr.ReadLine();
                    contact.Email = sr.ReadLine();

                    if (contact.ParentUserId == parentUserId)
                    {
                        result.Add(contact);
                    }
                }
            }
            finally
            {
                sr.Close();
                fs.Close();
            }

            return result;
        }
        
    }
}
