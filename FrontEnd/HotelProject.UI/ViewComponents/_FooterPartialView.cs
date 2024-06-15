using Microsoft.AspNetCore.Mvc;

namespace HotelProject.UI.ViewComponents
{
    public class _FooterPartialView : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
