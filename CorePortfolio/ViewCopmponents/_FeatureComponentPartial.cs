using CorePortfolio.DAL.Context;
using Microsoft.AspNetCore.Mvc;

namespace CorePortfolio.ViewCopmponents
{
    public class _FeatureComponentPartial : ViewComponent
    {
        CorePortfolioContext contex=new CorePortfolioContext();
        public IViewComponentResult Invoke()
        { 
            var values=contex.Features.ToList();
            return View(values);
        }
    }
}
