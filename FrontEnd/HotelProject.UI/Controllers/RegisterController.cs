using HotelProject.EntityLayer.Concrete;
using HotelProject.UI.Dtos.AppUser;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.UI.Controllers
{
    [AllowAnonymous]
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(CreateNewUserDto model)
        {
            var appuser = new AppUser()
            {
                FirstName = model.Name,
                LastName = model.Surname,
                UserName = model.UserName,
                ImageUrl="null",
                Department="null",
                WorkLocationID=1
            };
            if (model.Password == model.ConfirmPassword)
            {
                var result = await _userManager.CreateAsync(appuser, model.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
                }
            }
            return View();
        }
    }
}
