using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace HuseyinAtik.Web.ViewComponents.SocialMediaList
{
    public class SocialMediaList:ViewComponent
    {
        SocialMediaManager csm= new SocialMediaManager(new EfSocialMediaRepository());
        public IViewComponentResult Invoke()
        {
            var values = csm.GetList();

            return View(values);
        }
    }
}
