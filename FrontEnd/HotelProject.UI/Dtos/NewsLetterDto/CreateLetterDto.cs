using System.ComponentModel.DataAnnotations;

namespace HotelProject.UI.Dtos.NewsLetterDto
{
    public class CreateLetterDto
    {
        [Required(ErrorMessage ="Lütfen bilgirim almak istediğiniz mail adresinizi giriniz.")]
        [EmailAddress(ErrorMessage ="Geçerli mail adresi giriniz.")]
        public string Mail { get; set; }
    }
}
