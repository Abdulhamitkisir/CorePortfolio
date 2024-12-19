using Microsoft.AspNetCore.Mvc;

namespace CorePortfolio.ViewCopmponents
{
    public class _PortfolioComponentPartial :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
