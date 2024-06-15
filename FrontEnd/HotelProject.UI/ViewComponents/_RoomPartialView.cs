using Microsoft.AspNetCore.Mvc;

namespace HotelProject.UI.ViewComponents
{
    public class _RoomPartialView : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
