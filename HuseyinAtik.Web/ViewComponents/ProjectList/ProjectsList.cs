using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HuseyinAtik.Web.ViewComponents.ProjectList
{
    public class ProjectList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
