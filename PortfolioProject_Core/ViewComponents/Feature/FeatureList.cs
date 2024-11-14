using Microsoft.AspNetCore.Mvc;

namespace PortfolioProject_Core.ViewComponents.Feature
{
    public class FeatureList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {

        return View(); 
        }
    
    }
}
