using Microsoft.AspNetCore.Mvc;

namespace HuseyinAtik.Web.ViewComponents.SkillList
{
    public class SkillList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
