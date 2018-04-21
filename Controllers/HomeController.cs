using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

// ~step 1: Make Empty ASP file -> checkbox MVC folders
// ~step 2: Create empty Home Controller
// ~step 3: alter actionresult index() to return a string 

//===================

// ~step 8: Add a View to be returned. Right click index method and add view. Just hit add, don't alter params.
// ~Step 9: take a look at the params in html:  shared _Layout and Home View
// ~Step 10: If your ASP installed bootstrap when you created the file. 
            //Replace the html from !Doctype onward with the content from page 28 in the tutorial
            //CHANGE string Index() to ActionResult and return View() 
namespace MvcMusicStore.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/
        public ActionResult Index()
        {
            //return "String returned from HomeController.Index()";
            return View();
        }
    }
}