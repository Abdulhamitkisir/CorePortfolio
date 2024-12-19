using CorePortfolio.DAL.Context;
using Microsoft.AspNetCore.Mvc;

namespace CorePortfolio.ViewCopmponents
{
    public class _AboutComponentPartial : ViewComponent
    {
        CorePortfolioContext context=new CorePortfolioContext();
        public IViewComponentResult Invoke()
        {

            ViewBag.aboutTitle=context.Abouts.Select(x => x.Title).FirstOrDefault();
            ViewBag.aboutSubDescription = context.Abouts.Select(x=> x.SubDescription).FirstOrDefault();
            ViewBag.aboutDetail = context.Abouts.Select(x => x.Details).FirstOrDefault();
            return View();        
        }
    }
}
