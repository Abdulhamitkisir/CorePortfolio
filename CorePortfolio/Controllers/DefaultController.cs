using Microsoft.AspNetCore.Mvc;

namespace CorePortfolio.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
