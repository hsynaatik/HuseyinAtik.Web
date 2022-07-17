using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace HuseyinAtik.Web.ViewComponents.AboutList
{
    public class AboutList:ViewComponent
    {
        AboutManager aboutManager = new AboutManager(new EfAboutRepository());
        public IViewComponentResult Invoke()
        {
            var values = aboutManager.GetAboutListWithUser();
            return View(values);
        }
    }
}
