using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationSystem
{
    class AuthenticationManager
    {
        public static string LoggedUser { get; private set; }

        public static void AuthenticateUser(string username, string password)
        {
            if (username == "nikiv" && password == "nikipass")
                LoggedUser = username;
        }
    }
}
