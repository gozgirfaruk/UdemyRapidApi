using HotelProject.Business.Concrete;
using HotelProject.EntityLayer.Concrete;
using HotelProject.UI.Models.Role;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.UI.Controllers
{
    [AllowAnonymous]
    public class RoleAssignController : Controller
    {
        private readonly UserManager<AppUser> _userMenager;
        private readonly RoleManager<AppRole> _roleManager;

        public RoleAssignController(UserManager<AppUser> userMenager, RoleManager<AppRole> roleManager)
        {
            _userMenager = userMenager;
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            var values = _userMenager.Users.ToList();
            return View(values);
        }
        [HttpGet]
        public async Task<IActionResult> AssignRole(int id)
        {
            var user = _userMenager.Users.FirstOrDefault(x => x.Id == id);
            TempData["userid"] = user.Id;

            var roles = _roleManager.Roles.ToList();
            var userRoles = await _userMenager.GetRolesAsync(user);
            List<RoleAssignViewModel> models = new List<RoleAssignViewModel>();
            foreach(var item in roles)
            {
                RoleAssignViewModel model = new RoleAssignViewModel();
                model.RoleId = item.Id;
                model.RoleName = item.Name;
                model.RoleExist=userRoles.Contains(item.Name);
                models.Add(model);
            }
            return View(models);

        }
        [HttpPost]
        public async Task<IActionResult> AssignRole(List<RoleAssignViewModel> model)
        {
            var userid = (int)TempData["userid"];
            var user = _userMenager.Users.FirstOrDefault(x=>x.Id == userid);
            foreach(var item  in model)
            {
                if(item.RoleExist)
                {
                    await _userMenager.AddToRoleAsync(user,item.RoleName);
                }
                else
                {
                    await _userMenager.RemoveFromRoleAsync(user, item.RoleName);
                }
                
            }
            return RedirectToAction("Index");
        }
    }
}
