using Colledge.Domen.Models;
using Colledge.Infrastructure.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Colledge.Application.Features.ListUsers
{
    public class ListUsersHandler : IRequestHandler<ListUsersRequest, IEnumerable<User>>
    { 
        private readonly ColledgeContext _db;
        public ListUsersHandler(ColledgeContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<User>> Handle(ListUsersRequest request, CancellationToken cancellationToken)
        {
            var listUsers = await _db.Users.ToListAsync();
            if (listUsers != null)
            {
                return listUsers;
            }
            else
            {
                return null;
            }
        }
    }
}
