using Microsoft.AspNetCore.Mvc;

namespace BulyBookWeb.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
