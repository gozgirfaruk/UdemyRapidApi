﻿using HotelProject.UI.Dtos.RoomDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProject.UI.ViewComponents
{
    public class _RoomPartialView : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _RoomPartialView(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5204/api/Room");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultRoomDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
