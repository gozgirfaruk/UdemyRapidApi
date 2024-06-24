using HotelProject.Business.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorklocationController : ControllerBase
    {
        private readonly IWorklocationService _worklocationService;

        public WorklocationController(IWorklocationService worklocationService)
        {
            _worklocationService = worklocationService;
        }

        [HttpGet]
        public IActionResult LocationList()
        {
            var values = _worklocationService.TGetList();
            return Ok(values);
        }

        [HttpDelete]
        public IActionResult DeleteLocation(int id)
        {
            var values = _worklocationService.TGetByID(id);
            _worklocationService.TDelete(values);
            return Ok();
        }

        [HttpPost]
        public IActionResult InsertLocation(WorkLocation location)
        {
            _worklocationService.TInsert(location);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateLocation(WorkLocation location)
        {
            _worklocationService.TUpdate(location);
            return Ok();
        }
        [HttpGet("GetLocation")]
        public IActionResult GetLocation(int id)
        {
           var values = _worklocationService.TGetByID(id);
            return Ok(values);
        }
    }
}
