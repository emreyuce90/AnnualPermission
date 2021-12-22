
using AnnualPermissionApp.DTO;
using FluentValidation;

namespace AnnualPermissionApp.BLL.Validators.FluentValidation
{
    public class AppUserRegisterValidator:AbstractValidator<AppUserRegisterDto>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(I=> I.Username).NotEmpty().WithMessage("Kullanıcı adı alanı boş geçilemez");
            RuleFor(I=> I.EMail).NotEmpty().WithMessage("Email alanı boş geçilemez").EmailAddress();
            RuleFor(I=> I.Password).NotEmpty().WithMessage("Şifre alanı boş geçilemez");
            RuleFor(I=> I.ConfirmPassword).NotEmpty().WithMessage("Şifre alanı boş geçilemez");
            RuleFor(I=> I.Name).NotEmpty().WithMessage("Ad alanı boş geçilemez");
            RuleFor(I=> I.Surname).NotEmpty().WithMessage("Soyad alanı boş geçilemez");
            RuleFor(I=> I.EnterDate).NotEmpty().WithMessage("İşe Giriş tarihi alanı boş geçilemez");
            RuleFor(I=> I.Title).NotEmpty().WithMessage("Ünvan alanı boş geçilemez");
        }
    }
}

