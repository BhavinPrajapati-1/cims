using FluentValidation;

namespace CIMS.Models.Validators
{
    public class UnitProgressValidator : AbstractValidator<UnitProgressModel>
    {
        private readonly Validators v = new Validators();
        public UnitProgressValidator()
        {

        }
    }
}
