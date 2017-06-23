using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Tools;

namespace TaskManager.View
{
    class UserView
    {
        public void Show()
        {
            while (true)
            {
                Console.Clear();
                UserViewEnum choice = RenderMenu();
                switch (choice)
                {
                    case UserViewEnum.TaskManagement:
                        {
                            TaskManagementView taskManagementView = new View.TaskManagementView();
                            taskManagementView.Show();
                            break;
                        }
                    case UserViewEnum.CommentManagement:
                        {
                            CommentManagementView commentManagementView = new CommentManagementView();
                            commentManagementView.Show();
                            break;
                        }
                    case UserViewEnum.Exit:
                        {
                            return;
                        }
                }
            }
        }

        private UserViewEnum RenderMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("[T]ask management");
                Console.WriteLine("[C]omment management");
                Console.WriteLine("E[x]it");
                string choice = Console.ReadLine();
                switch (choice.ToUpper())
                {
                    case "T":
                        {
                            return UserViewEnum.TaskManagement;
                        }
                    case "C":
                        {
                            return UserViewEnum.CommentManagement;
                        }
                    case "X":
                        {
                            return UserViewEnum.Exit;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid choice");
                            Console.ReadKey(true);
                            break;
                        }
                }
            }
        }
    }
}
