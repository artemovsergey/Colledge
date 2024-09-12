using Colledge.Domen.Models;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colledge.Application.Features.ListUsers
{
    public class ListUsersRequest : IRequest<IEnumerable<User>>
    {
        public IEnumerable<User> Users { get; set; }
    }

    public class ListUsersRequestValidator : AbstractValidator<ListUsersRequest>
    {
        public ListUsersRequestValidator()
        {
            RuleFor(x => x.Users).NotEmpty().WithMessage("Список пользователей не может быть пустым");
            // Предположим, что у нас есть специфические требования к данным пользователей
            RuleFor(x => x.Users).Must(users => users.All(u => u != null)).WithMessage("Все пользователи должны быть непустыми");
        }
    }
}
