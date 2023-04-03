using Application.Repositories.UserRepository;
using Domain.Entities;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.UserRepositoryConcrete
{
    public class UserReadRepository : ReadRepository<User>, IUserReadRepository
    {
        public UserReadRepository(DuvarAPIDbContext context) : base(context)
        {
        }
    }
}
