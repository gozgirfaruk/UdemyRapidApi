using HotelProject.Business.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SendMessageController : ControllerBase
    {
        private readonly ISendMessageService _sendMessageService;

        public SendMessageController(ISendMessageService sendMessageService)
        {
            _sendMessageService = sendMessageService;
        }

        [HttpGet]
        public IActionResult MessageList()
        {
            var values = _sendMessageService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult InsertMessage(SendMessage sendMessage)
        {
            _sendMessageService.TInsert(sendMessage);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteMessage(int id )
        {
            var values = _sendMessageService.TGetByID(id);
            _sendMessageService.TDelete(values);
            return Ok();
        }
        [HttpGet("GetMessage")]
        public IActionResult GetMessage(int id)
        {
            var values = _sendMessageService.TGetByID(id);
            return Ok(values);
        }
        [HttpPut]
        public IActionResult UpdateMessage(SendMessage sendMessage)
        {
            _sendMessageService.TUpdate(sendMessage);
            return Ok();
        }
    }
}
