using Microsoft.AspNetCore.Mvc;

namespace HotelProject.UI.Controllers
{
    public class AdminLayout : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
