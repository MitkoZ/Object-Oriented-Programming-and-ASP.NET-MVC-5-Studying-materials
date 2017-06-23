using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCFilters.Helpers
{
    /// <summary>
    /// A custom class to restrict controller actions from accessing from not-logged users or users which are not administrators
    /// If the user is not logged in - redirect to login page
    /// If the user is not administrator or is not allowed to access the action - go to AccessDenied page
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false)]
    public class CustomAuthorizeAttribute : FilterAttribute, IAuthorizationFilter
    {
        /// <summary>
        /// If you want to explicitly allow for a common user to access an action, set this to true
        /// </summary>
        public bool AllowAccessToUser { get; set; }

        public void OnAuthorization(AuthorizationContext filterContext)
        {
            // if the Action or its Controller has [AllowAnonymous] attribute - do not perform validation
            if (filterContext.ActionDescriptor.GetCustomAttributes(typeof(AllowAnonymousAttribute), true).Any()
                || filterContext.ActionDescriptor.ControllerDescriptor.GetCustomAttributes(typeof(AllowAnonymousAttribute), true).Any())
            {
                return;
            }

            // check if the current session is not authenticated - then redirect to login
            if (LoginUserSession.Current.IsAuthenticated == false)
            {
                filterContext.Result = new RedirectToRouteResult(
                    new RouteValueDictionary(new { controller = "Home", action = "Login" }));
            }
            // then check if the current user should be able to access the action
            else if (AllowAccessToUser == false && LoginUserSession.Current.IsAdministrator == false)
            {
                filterContext.Result = new ViewResult { ViewName = "AccessDenied" };
            }
        }
    }
}