using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public string Index()
        {
            return "This is my <b>default</b> action...";
        }

        // Try http://localhost:49646/HelloWorld/Welcome/Harry/5
        public string Welcome(string name, int ID)
        {
            return HttpUtility.HtmlEncode("Hello, " + name + ", ID is " + ID);
        }
    }
}