namespace HotelProject.UI.Dtos.RoomDto
{
    public class CreateRoomDto
    {
        public string RoomNumber { get; set; }
        public string CoverImage { get; set; }
        public int Price { get; set; }
        public string Title { get; set; }
        public int BedCount { get; set; }
        public int BathCount { get; set; }
        public string Description { get; set; }
        public bool Wifi { get; set; }
    }
}
