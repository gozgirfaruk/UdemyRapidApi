using AutoMapper;
using HotelProject.UI.Dtos.ServiceDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProject.UI.ViewComponents.DashboardViewComponents
{
    public class _WidgetPartialView : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _WidgetPartialView(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5204/api/DashboardWidget/StaffCount");


            var client1 = _httpClientFactory.CreateClient();
            var responseMessage1 = await client1.GetAsync("http://localhost:5204/api/DashboardWidget/RoomCount");

            var client2 = _httpClientFactory.CreateClient();
            var responseMessage2 = await client2.GetAsync("http://localhost:5204/api/DashboardWidget/TestCount");
            //LocationCount
            var client3 = _httpClientFactory.CreateClient();
            var responseMessage3 = await client3.GetAsync("http://localhost:5204/api/DashboardWidget/LocationCount");



            if (responseMessage.IsSuccessStatusCode & responseMessage1.IsSuccessStatusCode & responseMessage2.IsSuccessStatusCode & responseMessage3.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                ViewBag.staff = jsonData;

                var jsonData1 = await responseMessage1.Content.ReadAsStringAsync();
                ViewBag.room = jsonData1;

                var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
                ViewBag.test=jsonData2;

                var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
                ViewBag.location = jsonData3;


                return View();
            }
            return View();
        }
    }
}
