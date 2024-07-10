using Microsoft.AspNetCore.Mvc;
using UdemyProject.DataAccesLayer.Context;

namespace UdemyProject.ViewComponents
{
    public class SkillComponentPartial : ViewComponent
    {

        Context dbContext = new Context();
        public IViewComponentResult Invoke()
        {
            var values = dbContext.Skills.ToList();
            return View(values);
        }
    }
}
