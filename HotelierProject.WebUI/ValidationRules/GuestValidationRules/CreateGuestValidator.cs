using FluentValidation;
using HotelierProject.WebUI.Dtos.GuestDto;

namespace HotelierProject.WebUI.ValidationRules.GuestValidationRules
{
    public class CreateGuestValidator : AbstractValidator<CreateGuestDto>
    {
        public CreateGuestValidator()
        {
            RuleFor(x => x.Name)
            .NotEmpty().WithMessage("İsim alanı boş geçilemez")
            .MinimumLength(3).WithMessage("Lütfen en az 3 karakter veri girişi yapınız")
            .MaximumLength(20).WithMessage("Lütfen en fazla 20 karakter veri girişi yapınız");

            // Surname alanı için doğrulamalar
            RuleFor(x => x.Surname)
                .NotEmpty().WithMessage("Soyisim alanı boş geçilemez")
                .MinimumLength(2).WithMessage("Lütfen en az 2 karakter veri girişi yapınız")
                .MaximumLength(30).WithMessage("Lütfen en fazla 30 karakter veri girişi yapınız");

            // City alanı için doğrulamalar
            RuleFor(x => x.City)
                .NotEmpty().WithMessage("Şehir alanı boş geçilemez")
                .MinimumLength(3).WithMessage("Lütfen en az 3 karakter veri girişi yapınız")
                .MaximumLength(20).WithMessage("Lütfen en fazla 20 karakter veri girişi yapınız");
        }
    
    }
}
