using Microsoft.AspNetCore.Mvc;

namespace HotelProject.UI.ViewComponents
{
    public class _VideoPartialView : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
