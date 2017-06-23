using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PagingSortingSearch.Models
{


    public class SearchViewModel2
    {
        public const int DefaultPageSize = 3;

        public int PageSize { get; set; }

        public string LastSortColumn { get; set; }
        public string LastSortDirection { get; set; }

        public int CurrentPageIndex { get; set; }
        public int TotalPagesCount { get; set; }
        public int TotalItemsCount { get; set; }

        public bool HasFirstPage
        {
            get { return CurrentPageIndex > 1; }
        }
        public bool HasLastPage
        {
            get { return CurrentPageIndex < TotalPagesCount; }
        }
        public bool HasPrevPage
        {
            get { return CurrentPageIndex > 1; }
        }
        public bool HasNextPage
        {
            get { return CurrentPageIndex < TotalPagesCount; }
        }


        public List<SearchItem> SearchItems;

        public SearchViewModel2()
        {
            this.PageSize = DefaultPageSize;
            SearchItems = new List<SearchItem>();
        }

        public SearchViewModel2(List<Restaurant> list, int pageSize, int pageIndex, int recordsCount)
            : this()
        {
            // shorter way for the code below
            //list.ForEach(item => SearchItems.Add(new SearchItem(item)));

            foreach (Restaurant restaurant in list)
            {
                SearchItems.Add(new SearchItem(restaurant));
            }

            PageSize = pageSize;
            TotalItemsCount = recordsCount;
            TotalPagesCount = ((recordsCount - 1) / PageSize) + 1;
            CurrentPageIndex = pageIndex;
        }
    }
}