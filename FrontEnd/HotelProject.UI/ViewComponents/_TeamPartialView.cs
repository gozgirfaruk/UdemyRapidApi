using Microsoft.AspNetCore.Mvc;

namespace HotelProject.UI.ViewComponents
{
    public class _TeamPartialView : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
