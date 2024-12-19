using Microsoft.AspNetCore.Mvc;

namespace CorePortfolio.ViewCopmponents
{
    public class _FooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
