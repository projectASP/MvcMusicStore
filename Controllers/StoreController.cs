using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

// ~step 4: Create empty StoreController
// ~step 5:  create string Index, string Browse and string Details
// ~step 6: Run project (CTRL + F5 on windows run without debug) and examine these routes: 
            //localhost:yourport/Store
            //localhost:yourport/Store/Browse
            //localhost:yourport/Store/Details

// ~step 7: add some dynamic values to the routes.
            //check out Browse() again and the new functions.

// ~step 8: Do a similar message passing procedure process to Details() with an id number instead.


namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
        // GET: /Store
        public string Index()
        {
            return "String returned from StoreController.Index()";
        }

        //GET: /Store/Browse?genre=Disco
        public string Browse(string genre)
        { 
            //HttpUtility does this: /Store/Browse?Genre=<script>window.location=’http://hackersite.com’</script>.

            string message = HttpUtility.HtmlEncode("StoreController.Browse(string genre) returns Genre = " + genre);
            return message;

        }

        //GET: /Store/Details/id
        public string Details(int id)
        {
            //test localhost:portnum/Store/Details/anyInteger
            string message = "StoreController.Details(int id) returns ID = " + id;
            return message;
        }
    }
}