using CorePortfolio.DAL.Context;
using Microsoft.AspNetCore.Mvc;

namespace CorePortfolio.ViewCopmponents
{
    public class _ExperienceComponentPartial : ViewComponent
    {
        CorePortfolioContext context=new CorePortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values=context.Experiences.ToList();
            return View(values);
        }
    }
}
