using Microsoft.AspNetCore.Mvc;

namespace HuseyinAtik.Web.ViewComponents.FactList
{
    public class FactList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
