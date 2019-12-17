using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Index()
        {
            return "Hello world index";
        }

        public string Welcome()
        {
            return "./Welcome";
        }

        // requires using System.Text.Encodings.Web;
        // /HelloWorld/Hello/{ID}?{str&num}
        public string Hello(string str, string id = "testPath", int num = 0)
        {
            return HtmlEncoder.Default.Encode($"Hello {id}, str is: {str}, int is: {num}");
        }
    }
}