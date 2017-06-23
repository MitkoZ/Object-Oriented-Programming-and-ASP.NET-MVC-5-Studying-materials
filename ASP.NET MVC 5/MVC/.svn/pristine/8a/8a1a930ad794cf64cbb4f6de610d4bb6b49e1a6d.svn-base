using BaseSample1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaseSample1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShowString()
        {
            // no need for view here
            return Content("string value");
        }

        public ActionResult ShowCurrentDate()
        {
            ViewBag.Username = "Ivan";
            //ViewBag.Username = System.Environment.UserName;
            return View();
        }

        //public ActionResult GetUrlParameter([Bind(Prefix = "id")]  string username)  //   .../Home/ GetUrlParameter /pesho
        public ActionResult GetUrlParameter(string username, string number = "N/A")
        {
            ViewBag.Username = username;
            ViewBag.Number = number;
            return View();
        }

        public ActionResult ShowSubmitForm()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SaveSubmitForm(string username)
        {
            ViewBag.Username = username;
            ViewBag.Message = "We added the user: " + username;
            return View("ShowSubmitForm");
        }

        public ActionResult ViewPhonebook()
        {
            return View();
        }

        public ActionResult ViewPhonebookStrongType()
        {
            User[] phonebook = new User[3];
            phonebook[0] = new User { Username = "Ivan", Phonenumber = "08811111" };
            phonebook[1] = new User { Username = "Pesho", Phonenumber = "08822222" };

            User user = new User();
            user.Username = "Lili";
            user.Phonenumber = "08933333";
            phonebook[2] = user;

            return View(phonebook);
        }

        public ActionResult EditUser(string username)
        {
            User user = new Models.User() { Username = "Hristo", Phonenumber = "1111" };
            return View(user);
        }

        [HttpPost]
        //public ActionResult EditUser(string username, string phonenumber)
        public ActionResult EditUser(User user) // auto-mapping of object properties from the request
        {
            // here is important to notice that the User properties are updated

            ViewBag.Message = string.Format("The new phone for {0} is {1}", user.Username, user.Phonenumber);
            return View("EditUser");
        }
    }
}