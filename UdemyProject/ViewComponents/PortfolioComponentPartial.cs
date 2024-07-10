using Microsoft.AspNetCore.Mvc;

namespace UdemyProject.ViewComponents
{
    public class PortfolioComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
