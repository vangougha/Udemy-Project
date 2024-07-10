using Microsoft.AspNetCore.Mvc;
using UdemyProject.DataAccesLayer.Context;

namespace UdemyProject.ViewComponents
{
    public class AboutComponentPartial : ViewComponent
    {


        Context dbContext = new Context();
        public IViewComponentResult Invoke()
        {

            ViewBag.aboutTitle = dbContext.Abouts.Select(x => x.Title).FirstOrDefault();
            ViewBag.aboutSubDesc = dbContext.Abouts.Select(x=>x.SubDesc).FirstOrDefault();
            ViewBag.aboutDetails = dbContext.Abouts.Select(x=>x.Details).FirstOrDefault();
            var values = dbContext.Abouts.ToList();
            return View(values);
        }
    }
}
