using Microsoft.AspNetCore.Mvc;

namespace HuseyinAtik.Web.ViewComponents.ResumeList
{
    public class ResumeList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
