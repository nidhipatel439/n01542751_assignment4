﻿using System.Web;
using System.Web.Mvc;

namespace n01542751_Assignment4
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
