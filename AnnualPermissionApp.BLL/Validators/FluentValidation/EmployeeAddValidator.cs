using AnnualPermissionApp.DTO;
using FluentValidation;

namespace AnnualPermissionApp.BLL.Validators.FluentValidation{
    public class EmployeeAddValidator:AbstractValidator<EmployeeAddDto>{
        public EmployeeAddValidator()
        {
            RuleFor(I=>I.Name).NotEmpty().WithMessage("Plasiyer adı alanı boş geçilemez");
            RuleFor(I=>I.Surname).NotEmpty().WithMessage("Plasiyer soyadı alanı boş geçilemez");
            RuleFor(I=>I.Title).NotEmpty().WithMessage("Plasiyer ünvanı alanı boş geçilemez");
            RuleFor(I=>I.EnterDate).NotEmpty().WithMessage("Plasiyer işe giriş tarihi alanı boş geçilemez");
        }
    }
}