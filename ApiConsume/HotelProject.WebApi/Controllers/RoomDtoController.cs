using AutoMapper;
using HotelProject.Business.Abstract;
using HotelProject.DTOLayer.Dtos.RoomDto;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomDtoController : ControllerBase
    {
        private readonly IRoomService _roomService;
        private readonly IMapper _mapper;

        public RoomDtoController(IMapper mapper, IRoomService roomService)
        {
            _mapper = mapper;
            _roomService = roomService;
        }
        [HttpGet]
        public IActionResult RoomList()
        {
            var values = _roomService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddRoom(AddRoomDto dto)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var values = _mapper.Map<Room>(dto);
             _roomService.TInsert(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateRoom(UpdateRoomDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var values = _mapper.Map<Room>(dto);
            _roomService.TUpdate(values);
            return Ok();
        }
    }
}
