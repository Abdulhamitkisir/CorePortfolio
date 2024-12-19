using Microsoft.AspNetCore.Mvc;

namespace CorePortfolio.ViewCopmponents
{
    public class _HeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
