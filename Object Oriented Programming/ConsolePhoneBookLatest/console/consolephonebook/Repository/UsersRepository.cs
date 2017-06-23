using System;
using System.IO;
using System.Collections.Generic;
using ConsolePhonebook.Entity;

namespace ConsolePhonebook.Repository
{
    public class UsersRepository : BaseRepository<User>
    {
        public UsersRepository(string filePath) : base(filePath)
        { }

        protected override void PopulateEntity(StreamReader sr, User item)
        {
            item.Id = Convert.ToInt32(sr.ReadLine());
            item.FirstName = sr.ReadLine();
            item.LastName = sr.ReadLine();
            item.Username = sr.ReadLine();
            item.Password = sr.ReadLine();
        }

        protected override void WriteEntity(StreamWriter sw, User item)
        {
            sw.WriteLine(item.Id);
            sw.WriteLine(item.FirstName);
            sw.WriteLine(item.LastName);
            sw.WriteLine(item.Username);
            sw.WriteLine(item.Password);
        }
        
        public User GetByUsernameAndPassword(string username, string password)
        {
            FileStream fs = new FileStream(this.filePath, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);

            try
            {
                while (!sr.EndOfStream)
                {
                    User user = new User();
                    user.Id = Convert.ToInt32(sr.ReadLine());
                    user.FirstName = sr.ReadLine();
                    user.LastName = sr.ReadLine();
                    user.Username = sr.ReadLine();
                    user.Password = sr.ReadLine();

                    if (user.Username == username && user.Password == password)
                    {
                        return user;
                    }
                }
            }
            finally
            {
                sr.Close();
                fs.Close();
            }

            return null;
        }
    }
}
