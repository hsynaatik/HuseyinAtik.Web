using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace HuseyinAtik.Web.ViewComponents.SkillList
{
    public class SkillList : ViewComponent
    {
        SkillManager skillManager = new SkillManager(new EfSkillRepository());
        public IViewComponentResult Invoke()
        {
            var values = skillManager.GetList();
            return View(values);
        }
    }
}
