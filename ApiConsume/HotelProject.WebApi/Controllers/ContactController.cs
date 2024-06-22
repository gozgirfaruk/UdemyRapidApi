using HotelProject.Business.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }
        [HttpGet]
        public IActionResult ContactList()
        {
           var values =_contactService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult InsertContact(Contact contact)
        {
            contact.Date = DateTime.Now;
            _contactService.TInsert(contact);
            return Ok();
        }
    }
}
