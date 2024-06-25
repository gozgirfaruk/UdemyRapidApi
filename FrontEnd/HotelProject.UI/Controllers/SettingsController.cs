using HotelProject.EntityLayer.Concrete;
using HotelProject.UI.Models.Setting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.UI.Controllers
{
    public class SettingsController : Controller
    {
        private readonly UserManager<AppUser> _userMenager;

        public SettingsController(UserManager<AppUser> userMenager)
        {
            _userMenager = userMenager;
        }


        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var user = await _userMenager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel editModel = new UserEditViewModel();
            editModel.Name = user.FirstName;
            editModel.Surname = user.LastName;
            editModel.UserName = user.UserName;
            editModel.Mail=user.Email;
            return View(editModel);
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel model)
        {
            if (model.Password == model.ConfirmedPassword)
            {
                var user = await _userMenager.FindByNameAsync(User.Identity.Name);
                user.FirstName = model.Name;
                user.LastName = model.Surname;
                user.Email = model.Mail;
                user.PasswordHash = _userMenager.PasswordHasher.HashPassword(user, model.Password);
                await _userMenager.UpdateAsync(user);
                return RedirectToAction("Index", "Login");
            }
            return View(model);
        }
    }
}
