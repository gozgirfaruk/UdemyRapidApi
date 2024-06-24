using AutoMapper;
using HotelProject.UI.Dtos.ServiceDto;
using HotelProject.UI.Dtos.WorkLocation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace HotelProject.UI.Controllers
{
    [AllowAnonymous]
    public class WorklocationController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IHttpClientFactory _httpClientFactory;

        public WorklocationController(IHttpClientFactory httpClientFactory, IMapper mapper)
        {
            _httpClientFactory = httpClientFactory;
            _mapper = mapper;
        }
        public async Task<IActionResult> LocationList()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5204/api/Worklocation");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultWorklocationDto>>(jsonData);
                return View(values);
            }
            return View();
        }

        [HttpGet]
        public IActionResult CreateLocation()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> CreateLocation(CreateWorklocationDto model)
        {
          
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(model);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("http://localhost:5204/api/Worklocation", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("LocationList");
            }
            return View();
        }

        public async Task<IActionResult> DeleteLocation(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"http://localhost:5204/api/Worklocation/?id={id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("LocationList");
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> UpdateLocation(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:5204/api/Worklocation/GetLocation?id={id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateLocationDto>(jsonData);
                return View(values);
            }

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateLocation(UpdateLocationDto model)
        {
         
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(model);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("http://localhost:5204/api/Worklocation/", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("LocationList");
            }
            return View();
        }
    }
}
