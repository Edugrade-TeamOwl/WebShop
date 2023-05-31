using Microsoft.AspNetCore.Mvc;

namespace WebShop.Controllers
{
    public class StatisticsController : Controller
    {
        public IActionResult OverView()
        {
            return View();
        }
    }
}