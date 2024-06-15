using HotelProject.Business.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        [HttpGet]
        public IActionResult AboutList()
        {
            var values = _aboutService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddAbout(AboutUs about)
        {
            _aboutService.TInsert(about);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateAbout(AboutUs about)
        {
            _aboutService.TUpdate(about);
            return Ok();
        }
        [HttpDelete]
        public IActionResult AboutDelete(int id)
        {
            var value = _aboutService.TGetByID(id);
            _aboutService.TDelete(value);
            return Ok();
        }
        [HttpGet("GetAbout")]
        public IActionResult GetAbout(int id)
        {
            var value = _aboutService.TGetByID(id);
            return Ok(value);
        }
    }
}
