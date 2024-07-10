using Microsoft.AspNetCore.Mvc;

namespace UdemyProject.ViewComponents
{
    public class NavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
