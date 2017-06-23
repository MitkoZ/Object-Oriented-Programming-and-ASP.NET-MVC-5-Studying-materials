﻿using Restaurants.DataAccess.Entities;
using Restaurants.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurants.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            // get all cities
            CityRepository cityRepository = new CityRepository();
            List<City> cities = cityRepository.GetAll();
            System.Console.WriteLine("The cities are: ");
            foreach (City item in cities)
            {
                System.Console.WriteLine(item.Name);
            }

            System.Console.WriteLine();

            // search city by ID
            City city = cityRepository.GetByID(1);
            System.Console.Write("The city with id=1 is: ");
            if (city != null)
            {
                System.Console.WriteLine(city.Name);
            }
            else
            {
                System.Console.WriteLine("not found");
            }

            System.Console.WriteLine();

            // get all restaurants
            RestaurantRepository restaurantRepository = new RestaurantRepository();
            List<Restaurant> restaurants = restaurantRepository.GetAll();
            System.Console.WriteLine("The restaurants are: ");
            foreach (Restaurant item in restaurants)
            {
                string line = string.Format("{0} - {1} - {2} - {3} - {4}", item.Name, item.CityName, item.CategoryName, item.Description, item.DateCreated.ToShortDateString());
                System.Console.WriteLine(line);
            }

            System.Console.WriteLine();

            // get all restaurants from Veliko Tarnovo
            restaurants = restaurantRepository.GetByCityID(1);
            System.Console.WriteLine("The restaurants from Valiko Tarnovo are: ");
            foreach (Restaurant item in restaurants)
            {
                string line = string.Format("{0} - {1} - {2} - {3} - {4}", item.Name, item.CityName, item.CategoryName, item.Description, item.DateCreated.ToShortDateString());
                System.Console.WriteLine(line);
            }

            System.Console.WriteLine();

            // insert new restaurant
            Restaurant newRestaurant = new Restaurant();
            newRestaurant.Name = "new restaurant";
            newRestaurant.Description = "description";
            newRestaurant.CategoryID = 1;
            newRestaurant.CityID = 2;
            newRestaurant.ImageName = "";
            restaurantRepository.Create(newRestaurant);
            System.Console.WriteLine("added new restaurant. The iD is: " + newRestaurant.ID);

            System.Console.WriteLine();

            //restaurantRepository.DeleteByID(newRestaurant.ID);
            //System.Console.WriteLine("deleting restaurant with ID = " + newRestaurant.ID);

            System.Console.Read();
        }
    }
}