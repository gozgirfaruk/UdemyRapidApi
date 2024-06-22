using FluentValidation;
using HotelProject.UI.Dtos.GuestDtos;

namespace HotelProject.UI.ValidationRules.GuestValidator
{
    public class CreateGuestValidator : AbstractValidator<CreateGuestDto>
    {
        public CreateGuestValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim alanı boş geçilemez.").MinimumLength(3).WithMessage("İsim 3 karakterden kısa olamaz.").MaximumLength(12).WithMessage("İsim 12 karakterden fazla olamaz");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyisim alanı boş geçilemez").MinimumLength(5).WithMessage("Soyisim 5 karakterden az girilemez.").MaximumLength(15).WithMessage("soyisim 15 karakterden uzun girilemez.");
        }
    }
}
