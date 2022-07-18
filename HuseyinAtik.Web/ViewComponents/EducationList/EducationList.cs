using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace HuseyinAtik.Web.ViewComponents.EducationList
{
    public class EducationList:ViewComponent
    {
        EducationManager educationManager = new EducationManager(new EfEducationRepository());
        public IViewComponentResult Invoke()
        {
            var values = educationManager.GetList();
            return View(values);
        }
    }
}
