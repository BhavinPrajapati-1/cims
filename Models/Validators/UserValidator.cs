
using FluentValidation;

namespace CIMS.Models.Validators
{
    public class UserValidator : AbstractValidator<UserModel>
    {
        private readonly Validators v = new Validators();
        public UserValidator()
        {

        }
    }
}
