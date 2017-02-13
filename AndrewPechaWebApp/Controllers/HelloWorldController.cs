using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AndrewPechaWebApp.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/ 

        public ActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome(int id = 1)
        {
            string returnString = string.Empty;

            if (id == 69)
            {
                return HttpUtility.HtmlEncode("Shutup Dylan! >:O");
            }

            else
            {
                for (int i = 0; i < id; i++)
                {
                    returnString = returnString + "Return String!\n";
                }
            }

            return HttpUtility.HtmlEncode(returnString).Replace("\n", "<br />");
        }
    }
}