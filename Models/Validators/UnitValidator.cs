using FluentValidation;

namespace CIMS.Models.Validators
{
    public class UnitValidator : AbstractValidator<UnitModel>
    {
        private readonly Validators v = new Validators();
        public UnitValidator()
        {
            RuleFor(x => x.Name)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .Length(2, 50);

            RuleFor(x => x.TypeName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty();

            RuleFor(x => x.Address)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .Length(5, 150);

            RuleFor(x => x.StatusName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty();

            RuleFor(x => x.StartDate)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty();

            RuleFor(x => x.CompletionDate)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty();

        }
    }
}
