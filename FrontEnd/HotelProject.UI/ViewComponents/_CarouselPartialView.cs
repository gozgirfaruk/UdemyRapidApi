using Microsoft.AspNetCore.Mvc;

namespace HotelProject.UI.ViewComponents
{
    public class _CarouselPartialView : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
