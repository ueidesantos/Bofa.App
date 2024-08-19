using Bofa.App.Domain.Core;
using FluentValidation;

namespace Bofa.App.Application.Services
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(user => user.Name).NotEmpty();
            
            RuleFor(user => user.Age)
                .NotEmpty()
                .GreaterThanOrEqualTo(16);
        }
    }
}
