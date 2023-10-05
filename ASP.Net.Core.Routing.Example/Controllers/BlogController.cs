using Microsoft.AspNetCore.Mvc;

namespace ASP.Net.Core.Routing.Example.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Article()
        {
            return View();
        }
    }
}
