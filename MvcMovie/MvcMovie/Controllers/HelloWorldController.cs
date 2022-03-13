using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //My Hello World

        // default Hello World action
        // called when no index is provided
        // GET: /HelloWorld/
        public IActionResult Index()
        {
            // return the controller's view so it looks nice.
            return View();
        }

        // Welcome action
        // Is passed name and numTimes via the URL
        // Ex: https://localhost:{PORT}/HelloWorld/Welcome?name=Rick&numtimes=4
        // GET: /HelloWorld/Welcome/ 
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            // ViewData is a database that has no defined properties until added to.
            // These two lines are accepting the parameters, then adding them to the database to be accessed in the view
            ViewData["Messages"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            // return the view.
            return View();
        }
    }
}
