﻿using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity.Owin;

namespace Tamin.Helpers
{
    public static class IdentityHelpers
    {
        public static MvcHtmlString GetUserName(this HtmlHelper html, string id)
        {
            ApplicationUserManager mgr = HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>();
            return new MvcHtmlString(mgr.FindByIdAsync(id).Result.UserName);
        }

        public static MvcHtmlString GetRoleName(this HtmlHelper html, string id)
        {
            ApplicationRoleManager mgr = HttpContext.Current.GetOwinContext().GetUserManager<ApplicationRoleManager>();
            return new MvcHtmlString(mgr.FindByIdAsync(id).Result.Name);
        }



    }
}