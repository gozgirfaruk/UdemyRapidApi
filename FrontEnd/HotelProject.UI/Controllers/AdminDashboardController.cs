using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.UI.Controllers
{
    public class AdminDashboardController : Controller
    {
        public IActionResult Dash()
        {
            return View();
        }
    }
}
