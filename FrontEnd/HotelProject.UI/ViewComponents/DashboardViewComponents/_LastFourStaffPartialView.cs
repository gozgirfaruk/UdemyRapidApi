using HotelProject.UI.Dtos.DashboardDtos;
using HotelProject.UI.Dtos.ServiceDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProject.UI.ViewComponents.DashboardViewComponents
{
    public class _LastFourStaffPartialView : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _LastFourStaffPartialView(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5204/api/DashboardWidget/FourStaff");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<LastStaffDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
