using HotelProject.Business.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuestController : ControllerBase
    {
        private readonly IGuestService _guestService;

        public GuestController(IGuestService guestService)
        {
            _guestService = guestService;
        }
        [HttpGet]
        public IActionResult GuestList()
        {
            var values = _guestService.TGetList();
            return Ok(values);
        }
        [HttpDelete]
        public IActionResult DeleteGuest(int id)
        {
            var values = _guestService.TGetByID(id);
            _guestService.TDelete(values);
            return Ok();
        }

        [HttpPost]
        public IActionResult InsertGuest(Guest guest)
        {
            _guestService.TInsert(guest);
            return Ok();
        }

        [HttpGet("GetGuest")]
        public IActionResult GetGuest(int id)
        {
            var values = _guestService.TGetByID(id);
            return Ok(values);
        }
        [HttpPut]
        public IActionResult UpdateGuest(Guest guest)
        {
            _guestService.TUpdate(guest);
            return Ok();
        }
    }
}
