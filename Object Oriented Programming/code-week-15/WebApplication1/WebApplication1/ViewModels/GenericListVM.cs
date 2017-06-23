using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.ViewModels
{
    public class GenericListVM<T>
    {
        public List<T> Items = new List<T>();
    }
}