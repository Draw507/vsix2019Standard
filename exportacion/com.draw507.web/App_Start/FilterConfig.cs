﻿using $safeprojectname$.Filters;
using System.Web;
using System.Web.Mvc;

namespace $safeprojectname$
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new CustomHandleErrorAttribute());
        }
    }
}
