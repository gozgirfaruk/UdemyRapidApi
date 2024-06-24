using HotelProject.Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardWidgetController : ControllerBase
    {
        private readonly IStaffService _staffService;
        private readonly ITestimonialService _testimonialService;
        private readonly IRoomService _roomService;
        private readonly IWorklocationService _worklocationService;
        private readonly IBookingService _bookingService;

        public DashboardWidgetController(IStaffService staffService, ITestimonialService testimonialService, IRoomService roomService, IWorklocationService worklocationService, IBookingService bookingService)
        {
            _staffService = staffService;
            _testimonialService = testimonialService;
            _roomService = roomService;
            _worklocationService = worklocationService;
            _bookingService = bookingService;
        }

        [HttpGet("StaffCount")]
        public IActionResult StaffCount()
        {
            var values = _staffService.TStaffCount();
            return Ok(values);

        }

        [HttpGet("TestCount")]
        public IActionResult TestCount()
        {
            var values = _testimonialService.TTestCount();
            return Ok(values);
        }

        [HttpGet("RoomCount")]
        public IActionResult RoomCount()
        {
            var values = _roomService.TRoomCount();
            return Ok(values);
        }

        [HttpGet("LocationCount")]
        public IActionResult LocationCount()
        {
            var values = _worklocationService.TLocationCount();
            return Ok(values);
        }

        [HttpGet("FourStaff")]
        public IActionResult FourStaff()
        {
            var values = _staffService.TLastFourStaff();
            return Ok(values);
        }

        [HttpGet("LastReservations")]
        public IActionResult LastReservations()
        {
            var values = _bookingService.TLastReservation();
            return Ok(values);
        }
    }
}
