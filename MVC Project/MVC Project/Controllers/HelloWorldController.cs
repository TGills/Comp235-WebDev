using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Project.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public string Index()
        {
            return "Hello world! <br /> This is my first controller";
        }

        public string Welcome(string name, int id)
        {
            return HttpUtility.HtmlEncode("Welcome " + name + " . Your number is " + id);
        }
    }
}