namespace HotelProject.UI.Dtos.DashboardDtos
{
    public class LastReservationDto
    {
        public int BookingID { get; set; }
        public string Name { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public string? SpecialRequest { get; set; }
        public bool Status { get; set; }
    }
}
