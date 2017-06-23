using BaseSample2.Helpers;
using BaseSample2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaseSample2.Controllers
{
    public class UserController : Controller
    {
        //List<User> users = new List<Models.User>();

        // GET: CRUD
        public ActionResult Index()
        {
            // add default record if there are no records
            if (SessionObjects.Users.Count == 0)
            {
                User user = new Models.User() {Username="Hristo",  Phonenumber="1111"};
                SessionObjects.Users.Add(user);
            }
            List<User> model = SessionObjects.Users;
            return View(model);
        }

        public ActionResult ViewUser(string username)
        {
            User user = SessionObjects.Users.FirstOrDefault(c => c.Username == username);
            return View(user);
            //return View("ViewUser", user);
        }
        public ActionResult EditUser(string username)
        {
            User user = SessionObjects.Users.FirstOrDefault(c => c.Username == username);
            if (user == null)
            {
                user = new User();
            }
            return View(user);
        }

        [HttpPost]
        public ActionResult EditUser(User user, string oldUsername)
        {
            User userInList = SessionObjects.Users.FirstOrDefault(c => c.Username == oldUsername);
            if (userInList == null)
            {
                SessionObjects.Users.Add(user);
            }
            else
            {
                userInList.Username = user.Username;
                userInList.Phonenumber = user.Phonenumber;
            }

            ViewBag.Message = string.Format("The new phone for {0} is {1}", user.Username, user.Phonenumber);

            List<User> model = SessionObjects.Users;
            return View("Index", model);
        }

        public ActionResult DeleteUser(string username)
        {
            User user = SessionObjects.Users.FirstOrDefault(c => c.Username == username);
            if (user != null)
            {
                SessionObjects.Users.Remove(user);
            }

            List<User> model = SessionObjects.Users;
            return View("Index", model);
        }
    }
}