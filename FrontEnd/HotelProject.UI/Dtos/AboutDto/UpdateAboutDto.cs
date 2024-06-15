namespace HotelProject.UI.Dtos.AboutDto
{
    public class UpdateAboutDto
    {
        public int AboutUsID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int RoomCount { get; set; }
        public int StaffCount { get; set; }
        public int CustomerCount { get; set; }
    }
}
