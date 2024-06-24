using AutoMapper;
using HotelProject.UI.Dtos.ContactDtos;
using HotelProject.UI.Dtos.ServiceDto;
using HotelProject.UI.Models.Staff;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace HotelProject.UI.Controllers
{
    public class AdminContractController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminContractController(IHttpClientFactory httpClientFactory, IMapper mapper)
        {
            _httpClientFactory = httpClientFactory;
            _mapper = mapper;
        }
        public async Task<IActionResult> Inbox()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5204/api/Contact");
            var client2 = _httpClientFactory.CreateClient();
            var responseMessage2 = await client2.GetAsync("http://localhost:5204/api/Contact/GetContact");
            if (responseMessage.IsSuccessStatusCode & responseMessage2.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<InboxContactDto>>(jsonData);
                var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
                ViewBag.a = jsonData2;

                return View(values);
            }
           
           
            return View();
        }

        public async Task<IActionResult> Sendbox()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5204/api/SendMessage");

            var client2 = _httpClientFactory.CreateClient();
            var responseMessage2 = await client2.GetAsync("http://localhost:5204/api/SendMessage/GetSendCount");


            if (responseMessage.IsSuccessStatusCode & responseMessage2.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultSendboxDto>>(jsonData);

                var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
                ViewBag.b= jsonData2;
                return View(values);
            }
            return View();
        }


        [HttpGet]
        public IActionResult CreateMessage()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateMessage(SendmessageDto model)
        {
            model.SenderMail = "gozgirfaruk@gmail.com";
            model.SenderName = "Admin";
            model.Date=Convert.ToDateTime(DateTime.Now.ToShortDateString());
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(model);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("http://localhost:5204/api/SendMessage", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Inbox");
            }
            return View();
        }

        public async Task<IActionResult> MessageDetail(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:5204/api/SendMessage/GetMessage?id={id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<GetMessageByIdDto>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
