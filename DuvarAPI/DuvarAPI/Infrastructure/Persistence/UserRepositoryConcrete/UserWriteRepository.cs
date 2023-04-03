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
    public class UserWriteRepository : RepositoryWrite<User>, IUserWriteRepository
    {
        public UserWriteRepository(DuvarAPIDbContext context) : base(context)
        {
        }
    }
}
