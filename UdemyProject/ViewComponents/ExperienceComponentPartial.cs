using Microsoft.AspNetCore.Mvc;
using UdemyProject.DataAccesLayer.Context;

namespace UdemyProject.ViewComponents
{
    public class ExperienceComponentPartial : ViewComponent
    {


        Context dbContext = new Context();


        public IViewComponentResult Invoke()
        {
        
            var values = dbContext.Experiences.ToList();
            return View(values);
        }
    }
}
