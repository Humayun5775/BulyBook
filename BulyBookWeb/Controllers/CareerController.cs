using Microsoft.AspNetCore.Mvc;

namespace BulyBookWeb.Controllers
{
    public class CareerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
