using HotelProject.Business.Abstract;
using HotelProject.DataAccess.Concrete;
using HotelProject.WebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUserController : ControllerBase
    {
        private readonly IAppUserService _appuserService;

        public AppUserController(IAppUserService appuserService)
        {
            _appuserService = appuserService;
        }

        [HttpGet]
        public  IActionResult UserList()
        {
            var context = new ApiContext();
            var values = context.Users.Include(x => x.WorkLocation).Select(y => new AppUserLocationViewModel
            {
                FirstName = y.FirstName,
                LastName = y.LastName,
                WorkLocationID = y.WorkLocationID,
                City = y.City,
                ImageUrl = y.ImageUrl,
                LocationName = y.WorkLocation.Name

            }).ToList();
           //var values = _appuserService.TUserWithLocation();
            return Ok(values);
        }
    }
}
