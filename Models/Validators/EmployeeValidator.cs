using FluentValidation;

namespace CIMS.Models.Validators
{
    public class EmployeeValidator : AbstractValidator<EmployeeModel>
    {
        private readonly Validators v = new Validators();
        public EmployeeValidator()
        {
            RuleFor(x => x.LastName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .Must(v.BeAString)
                .Length(2, 50);

            RuleFor(x => x.FirstName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .Must(v.BeAString)
                .Length(2, 50);

            RuleFor(x => x.MiddleName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .Must(v.BeAString)
                .When(x=>!string.IsNullOrWhiteSpace(x.MiddleName))
                .MaximumLength(50);

            RuleFor(x => x.PositionName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty();

            RuleFor(x => x.ContactNumber)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .Length(5, 50);

            RuleFor(x => x.EmailAddress)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .EmailAddress();
        }

    }
}
