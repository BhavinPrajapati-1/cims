using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIMS.Models.Validators
{
    public class SupplierValidator : AbstractValidator<SupplierModel>
    {
        private readonly Validators v = new Validators();
        public SupplierValidator()
        {
            RuleFor(x => x.Name)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("{PropertyName} can't be empty.")
                .Must(v.BeAString).WithMessage("{PropertyName} " + v.InvalidString)
                .Length(2, 100);

            RuleFor(x => x.Address)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("{PropertyName} can't be empty.")
                .Must(v.BeAString).WithMessage("{PropertyName} " + v.InvalidString)
                .Length(5, 150);

            RuleFor(x => x.ContactNumber)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("{PropertyName} can't be empty.")
                .Length(5, 50);
        }
    }
}
