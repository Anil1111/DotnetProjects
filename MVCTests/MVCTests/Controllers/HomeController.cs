using Microsoft.AspNetCore.Mvc;
using MVCTests.Models;

namespace MVCTests.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View(SimpleRepository.SharedRepository.Products);

    }
}
