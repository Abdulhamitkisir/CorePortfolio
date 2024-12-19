using Microsoft.AspNetCore.Mvc;

namespace CorePortfolio.ViewCopmponents
{
    public class _ContactComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
