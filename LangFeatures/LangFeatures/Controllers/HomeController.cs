using Microsoft.AspNetCore.Mvc;

namespace LangFeatures.Controllers
{
    public class HomeController :Controller
    {
        public ViewResult Index()
        {
            return View(new string[] {"C#", "Language", "Features"});
        }
    }
}
