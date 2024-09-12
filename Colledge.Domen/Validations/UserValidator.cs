using Colledge.Domen.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colledge.Domen.Validations;

public class UserValidator : AbstractValidator<User>
{
    public UserValidator()
    {
        RuleFor(x => x.Name).Length(5).WithMessage("Please enter a name");
        RuleFor(x => x.Surname).NotEmpty().WithMessage("Please enter a description");
        RuleFor(x => x.Password).NotEmpty().WithMessage("Please enter a location");
        RuleFor(x => x.Login).NotEmpty().WithMessage("Please add a route instruction");
    }
}
