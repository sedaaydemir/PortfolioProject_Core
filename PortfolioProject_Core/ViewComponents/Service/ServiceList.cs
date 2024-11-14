using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioProject_Core.ViewComponents.Service
{
    public class ServiceList:ViewComponent
    {
        ServiceManager serviceManager = new ServiceManager(new EfserviceDal());
        public IViewComponentResult Invoke()
        {

            var values = serviceManager.TGetList();
            return View(values);
        }
    
    }
}
