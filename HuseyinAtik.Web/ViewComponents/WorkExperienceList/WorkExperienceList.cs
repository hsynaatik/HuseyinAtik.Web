using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace HuseyinAtik.Web.ViewComponents.WorkExperience
{
    public class WorkExperienceList:ViewComponent
    {
        WorkExperienceManager workExperienceManager = new WorkExperienceManager(new EfWorkExperienceRepository());

        public IViewComponentResult Invoke()
        {
            var values = workExperienceManager.GetList();
            return View(values);
        }
    }
}
