using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace CodeFirstPoj.Controllers
{
    public class HelloWorldController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }

        //// GET: /HelloWorld/Welcome/ 
        //public string Welcome(string name,int ID =1)
        //{
        //    //return "This is the Welcome action method....";
        //    // Interpolated Strings $"Hello {name}, NumTimes is: {numTimes}".
        //    return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        //}

    }
}
