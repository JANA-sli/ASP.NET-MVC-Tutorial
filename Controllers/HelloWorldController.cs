using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    [Authorize]
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string id)
        {
            ViewData["Message"] =  "Hello " + id;

            return View();
        }

        // requires using System.Text.Encodings.Web;
        // /HelloWorld/Hello/{ID}?{str&num}
        public string Hello(string str, string id = "testPath", int num = 0)
        {
            return HtmlEncoder.Default.Encode($"Hello {id}, str is: {str}, int is: {num}");
        }
    }
}
