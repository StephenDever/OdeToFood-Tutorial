using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio_Site.Controllers
{
    public class YearController : Controller
    {
        // GET: Year
        public ActionResult Search(string number = "All")
        {
            // number returns "All" as default value, will eventually return "All" page
            if (number == "All")
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                // encode user inquory for year
                var message = Server.HtmlEncode(number);
                return Content(message);
            }

        }
    }
}