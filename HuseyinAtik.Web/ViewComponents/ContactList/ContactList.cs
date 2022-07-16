using Microsoft.AspNetCore.Mvc;

namespace HuseyinAtik.Web.ViewComponents.ContactList
{
    public class ContactList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
