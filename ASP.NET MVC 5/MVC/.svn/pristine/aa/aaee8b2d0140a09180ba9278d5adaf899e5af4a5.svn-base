using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PagingSortingSearch.Models
{

    public class SearchItem
    {
        public int RestaurantID { get; set; }
        public string RestaurantName { get; set; }
        public string RestaurantCategory { get; set; }
        public string RestaurantCity { get; set; }

        public SearchItem(Restaurant dbRestaurant)
        {
            RestaurantID = dbRestaurant.ID;
            RestaurantName = dbRestaurant.Name;
            RestaurantCategory = dbRestaurant.Category.Name;
            RestaurantCity = dbRestaurant.City.Name;
        }
    }

    public class SearchViewModel
    {
        //bool HasNextPage { get; }
        //bool HasPreviousPage { get; }
        //bool IsFirstPage { get; }
        //bool IsLastPage { get; }
   //     public int PageCount { get; set; }
 //       public int PageNumber { get; set; }
  //      public int PageSize { get; set; }
       // public int TotalItemCount { get; set; }

        public string LastSortColumn { get; set; }
        public string LastSortDirection { get; set; }


        public List<SearchItem> SearchItems;

        public SearchViewModel()
        {
            SearchItems = new List<SearchItem>();
        }

        public SearchViewModel(List<Restaurant> list)
            : this()
        {
            list.ForEach(item => SearchItems.Add(new SearchItem(item)));
        }
    }
}