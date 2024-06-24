using HotelProject.EntityLayer.Concrete;
using HotelProject.UI.Dtos.WorkLocation;

namespace HotelProject.UI.Dtos.AppUser
{
    public class ResultAppUserListDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? City { get; set; }
        public string ImageUrl { get; set; }
        public int WorkLocationID { get; set; }
        public int WorkLocationName { get; set; }
    }
    
}
