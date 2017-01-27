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

        public string Index()
        {
            return "This is my <b>default</b> action...";
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome(int id = 1)
        {
            string returnString = string.Empty;

            for (int i = 0; i < id; i++)
            {
                returnString = returnString + "Return String!\n";
            }

            return HttpUtility.HtmlEncode(returnString).Replace("\n", "<br />");
        }
    }
}