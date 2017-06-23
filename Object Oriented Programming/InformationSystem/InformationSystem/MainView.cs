using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationSystem
{
    class MainView
    {
        public void Show()
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("Hello, " + AuthenticationManager.LoggedUser);
                Console.WriteLine("E[x]it");

                string choice = Console.ReadLine();
                if (choice.ToLower() == "x")
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid choice!");
                    Console.ReadKey(true);
                }
            }
        }
    }
}
