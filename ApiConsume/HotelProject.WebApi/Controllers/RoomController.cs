using HotelProject.Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        [HttpGet]
        public IActionResult RoomList()
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult AddRoom()
        {
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateRoom()
        {
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteRoom()
        {
            return Ok();
        }
        [HttpGet("GetRoom")]
        public IActionResult GetRoom()
        {
            return Ok();
        }

    }
}
