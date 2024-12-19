using Microsoft.AspNetCore.Mvc;
using CorePortfolio.DAL.Context;

namespace CorePortfolio.ViewCopmponents
{
    public class _SkillComponentPartial :ViewComponent
    {
        CorePortfolioContext context=new CorePortfolioContext();
        public IViewComponentResult Invoke()
        { 
            var values=context.Skills.ToList();
            return View(values);
        }
    }
}
