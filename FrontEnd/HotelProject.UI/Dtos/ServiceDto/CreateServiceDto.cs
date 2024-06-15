using System.ComponentModel.DataAnnotations;

namespace HotelProject.UI.Dtos.ServiceDto
{
    public class CreateServiceDto
    {
        [Required(ErrorMessage ="FontAweSome Türünde bir ikon giriniz.")]
        public string ServiceIcon { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
