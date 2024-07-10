using Microsoft.AspNetCore.Mvc;
using UdemyProject.DataAccesLayer.Context;

namespace UdemyProject.ViewComponents
{
    public class FeatureComponentPartial : ViewComponent
    {

        Context dbContext = new Context();
        public IViewComponentResult Invoke()
        {
            var values = dbContext.Features.ToList();
            return View(values);
        }
    }
}
