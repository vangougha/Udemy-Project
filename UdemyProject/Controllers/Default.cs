using Microsoft.AspNetCore.Mvc;

namespace UdemyProject.Controllers
{
    public class Default : Controller
    {
        public IActionResult Index()
        {
            //Bu sayfa özünde bir class'tır başka bi class'tan inheritance yapmış
            //IActionResult view dönmemi sağlıyor 

       


            return View();
        }
    }
}
