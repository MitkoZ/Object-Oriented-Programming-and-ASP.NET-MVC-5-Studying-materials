using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ListUsers()
        {
            GenericListVM<User> model = new GenericListVM<User>();
            model.Items.Add(new ViewModels.User() { Username = "Gosho", FirstName = "Gosho", LastName = "Goshev", Password = "1234566" });
            model.Items.Add(new ViewModels.User() { Username = "Pesho", FirstName = "Pesho", LastName = "Peshov", Password = "12467648567867" });
            return View(model);
        }

        public ActionResult ListContacts()
        {
            GenericListVM<Contact> model = new GenericListVM<Contact>();
            model.Items.Add(new Contact() { FullName="Peter petrov",Email="peter@gmail.com" });
            model.Items.Add(new Contact() { FullName = "John johnov", Email = "john@gmail.com" });
            return View(model);
        }
    }
}