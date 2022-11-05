using Microsoft.AspNetCore.Mvc;

namespace APITesting.Controllers
{
    [Route("/home")]
    public class HomeController : Controller
    {
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
