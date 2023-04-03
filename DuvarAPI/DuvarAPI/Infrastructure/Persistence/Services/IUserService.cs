using Domain.Common.ReturnTypes;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Services
{
    public interface IUserService
    {
        public Task<Result> Register(User newUser);
    }
}
