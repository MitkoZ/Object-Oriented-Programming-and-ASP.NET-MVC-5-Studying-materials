using ConsolePhonebook.Entity;
using ConsolePhonebook.Tools;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePhonebook.Repository
{
    public class PhonesRepository : BaseRepository<Phone>
    {
        public PhonesRepository(string filePath) : base(filePath)
        { }

        protected override void PopulateEntity(StreamReader sr, Phone item)
        {
            item.Id = Convert.ToInt32(sr.ReadLine());
            item.ParentContactId = Convert.ToInt32(sr.ReadLine());
            item.PhoneNumber = sr.ReadLine();
        }

        protected override void WriteEntity(StreamWriter sw, Phone item)
        {
            sw.WriteLine(item.Id);
            sw.WriteLine(item.ParentContactId);
            sw.WriteLine(item.PhoneNumber);
        }

        public List<Phone> GetAll(int parentContactId)
        {
            List<Phone> result = new List<Phone>();

            FileStream fs = new FileStream(this.filePath, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);

            try
            {
                while (!sr.EndOfStream)
                {
                    Phone phone = new Phone();
                    phone.Id = Convert.ToInt32(sr.ReadLine());
                    phone.ParentContactId = Convert.ToInt32(sr.ReadLine());
                    phone.PhoneNumber = sr.ReadLine();

                    if (phone.ParentContactId == parentContactId)
                    {
                        result.Add(phone);
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
