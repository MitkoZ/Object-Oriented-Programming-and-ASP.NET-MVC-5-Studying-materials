using FormFieldValidation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormFieldValidation.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // add Message to the Viewbag if another Action has added it to the TempData
            if (TempData["Message"] != null)
            {
                ViewBag.Message = TempData["Message"];
            }
            return View();
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(RegisterViewModel viewModel)
        {
            // server validation for Firstname to be with capital letter
            if (string.IsNullOrEmpty(viewModel.FirstName) == false)
            {
                char firstLetter = viewModel.FirstName[0];
                if (char.IsUpper(firstLetter) == false)
                {
                    ModelState.AddModelError("FirstName", "First name should start with a capital letter!");
                }
            }

            // server validation for the banned users
            if (viewModel.FirstName == "Ivan" && viewModel.LastName == "Ivanov")
            {
                ModelState.AddModelError("", "Sorry, this user is banned from our web server!");
            }

            // Do not save to database when the ModelState is not valid !
            if (ModelState.IsValid)
            {
                // save the information to the database
                // ...

                TempData["Message"] = "You registered succesfully!";
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        public JsonResult ValidateEmail(string email)
        {
            bool isEmailUsed = false;
            if (string.IsNullOrEmpty(email) == false)
            {
                isEmailUsed = (email == "trendo@abv.bg") || (email == "venelinmonev@gmail.com");
            }
            return Json(!isEmailUsed, JsonRequestBehavior.AllowGet);
        }
    }
}