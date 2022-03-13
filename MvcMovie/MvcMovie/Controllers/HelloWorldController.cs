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
        public string Index()
        {
            return "This is the Index/default action.";
        }

        // Welcome action
        // Is passed name and numTimes via the URL
        // Ex: https://localhost:{PORT}/HelloWorld/Welcome?name=Rick&numtimes=4
        // GET: /HelloWorld/Welcome/ 
        public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }
    }
}
