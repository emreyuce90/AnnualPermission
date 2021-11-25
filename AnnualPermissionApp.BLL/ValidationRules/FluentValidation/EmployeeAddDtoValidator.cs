using FluentValidation;
using PermissionApp.AnnualPermissionApp.DTO.EmployeesDtos;

namespace annualPermissions.PermissionApp.AnnualPermissionApp.BLL.ValidationRules.FluentValidation
{
    public class EmployeeAddDtoValidator : AbstractValidator<EmployeeAddDto>
    {
        public EmployeeAddDtoValidator()
        {
            RuleFor(I=>I.Name).NotEmpty().WithMessage("Plasiyer adı boş geçilemez");
            RuleFor(I=>I.Surname).NotEmpty().WithMessage("Plasiyer soyadı boş geçilemez");
            RuleFor(I=>I.Title).NotEmpty().WithMessage("Plasiyer ünvanı boş geçilemez");
            RuleFor(I=>I.EnterDate).NotEmpty().WithMessage("Plasiyer işe giriş tarihi boş geçilemez");

        }
    }
}
