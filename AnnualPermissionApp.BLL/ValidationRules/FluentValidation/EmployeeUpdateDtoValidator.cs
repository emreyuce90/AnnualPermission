using FluentValidation;
using PermissionApp.AnnualPermissionApp.DTO.EmployeesDtos;

namespace annualPermissions.PermissionApp.AnnualPermissionApp.BLL.ValidationRules.FluentValidation
{
    public class EmployeeUpdateDtoValidator : AbstractValidator<EmployeeUpdateDto>
    {
        public EmployeeUpdateDtoValidator()
        {
            RuleFor(I => I.Name).NotEmpty().WithMessage("Plasiyer ismi alanı boş geçilemez");
            RuleFor(I => I.Surname).NotEmpty().WithMessage("Plasiyer soyadı alanı boş geçilemez");
            RuleFor(I => I.Title).NotEmpty().WithMessage("Plasiyer ünvanı alanı boş geçilemez");
            RuleFor(I => I.Title).NotEmpty().WithMessage("Plasiyer ünvanı alanı boş geçilemez");
            RuleFor(I => I.EnterDate).NotEmpty().WithMessage("Plasiyer işe giriş tarihi alanı boş geçilemez");
        }
    }
}