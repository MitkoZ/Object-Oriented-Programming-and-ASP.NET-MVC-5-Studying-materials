﻿
using DataAccess;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityFrameworkSample.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {
            CategoryRepository categoryRepository = new CategoryRepository();
            //CategoryRepository categoryRepository2 = new CategoryRepository();
            var x = categoryRepository.GetAll();

            Category y = categoryRepository.GetByID(1);

            //categoryRepository.DeleteByID(1001);


            //Category y2 = new Category() ;// categoryRepository.GetByID(1002);
            //y2.ID = 1002;
            //y2.Name = "new name111";
            //categoryRepository.Update(y2);

            return View();
        }
    }
}