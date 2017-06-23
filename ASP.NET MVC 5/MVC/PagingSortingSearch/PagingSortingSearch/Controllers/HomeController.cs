﻿using PagingSortingSearch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PagingSortingSearch.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(string restaurantName, string sortColumn, string direction, int categoryID = 0)
        {
            RestaurantsEntities dbContext = new RestaurantsEntities();

            List<Category> allCategories = dbContext.Categories.ToList();
            ViewBag.AllCategories = new SelectList(allCategories, "ID", "Name", categoryID );

            //ViewBag.SortByName = string.IsNullOrEmpty(sortColumn) ? "NameDesc" : "";
            //ViewBag.SortByCategory = sortColumn == "Category" ? "CategoryDesc" : "Category";
            //ViewBag.SortByCity = sortColumn == "City" ? "CityDesc" : "City";

            //here we are converting the db.Restaurants to AsQueryable so that we can invoke all the extension methods on variable records.  
            IQueryable<Restaurant> records = dbContext.Restaurants.AsQueryable();

            // first filter the results
            if (string.IsNullOrEmpty(restaurantName) == false)
            {
                records = records.Where(r => r.Name.Contains(restaurantName));
            }
            if (categoryID != 0)
            {
                records = records.Where(r => r.CategoryID == categoryID);
            }
            
            // then sort by the specified column
            string sortColDirection = sortColumn + direction;
            switch (sortColDirection)
            {
                case "Category":
                    records = records.OrderBy(r => r.Category.Name);
                    break;
                case "CategoryDesc":
                    records = records.OrderByDescending(r => r.Category.Name);
                    break;
                case "City":
                    records = records.OrderBy(r => r.City.Name);
                    break;
                case "CityDesc":
                    records = records.OrderByDescending(r => r.City.Name);
                    break;
                case "NameDesc":
                    records = records.OrderByDescending(r => r.Name);
                    break;
                default:
                    records = records.OrderBy(r => r.Name);
                    break;
            }

            // convert the IQueryable list to list (i.e. retrieve the data from the database)
            List<Restaurant> list = records.ToList();

            // create the view model 
            SearchViewModel viewModel = new SearchViewModel(list);
            viewModel.LastSortColumn = sortColumn;
            viewModel.LastSortDirection = direction;

            return View(viewModel);
        }
    }
}