using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimerExample
{
    public class UserCollection
    {
        public event Action<User> UserAdded;
        private List<User> users = new List<User>();

        public void Add(User user)
        {
            users.Add(user);

            UserAdded(user);
        }
    }
}
