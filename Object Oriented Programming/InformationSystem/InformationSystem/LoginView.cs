using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationSystem
{
    class LoginView
    {
        public void Show()
        {
            while(true)
            {
                Console.Clear();
                Console.WriteLine("Authentication");
                Console.Write("Username: ");
                string username = Console.ReadLine();

                Console.Write("Password: ");
                string password = Console.ReadLine();

                AuthenticationManager.AuthenticateUser(username, password);

                if (!String.IsNullOrEmpty(AuthenticationManager.LoggedUser))
                    return;
                else
                {
                    Console.WriteLine("Invalid username or password!");
                    Console.ReadKey(true);
                }
            }
        }
    }
}
