using AnnualPermissionApp.DTO;
using FluentValidation;

namespace AnnualPermissionApp.BLL.Validators.FluentValidation
{
    public class AppUserLoginDtoValidator : AbstractValidator<AppUserLoginDto>
    {
        public AppUserLoginDtoValidator()
        {
            RuleFor(I=> I.Username).NotEmpty().WithMessage("Kullanıcı adı alanı boş geçilemez");
            RuleFor(I=> I.Password).NotEmpty().WithMessage("Şifre alanı boş geçilemez");

        }
    }
}