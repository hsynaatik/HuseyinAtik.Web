using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HuseyinAtik.Web.ViewComponents.ProjectList
{
    public class ProjectList:ViewComponent
    {
        ProjectManager projectManager = new ProjectManager(new EfProjectRepository());

        public IViewComponentResult Invoke()
        {
            var values = projectManager.GetProjectListWithCategory();
            return View(values);
        }
    }
}
