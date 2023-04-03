using Application.Repositories.EntryRepository;
using Domain.Entities;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.EntryRepositoryConcrete
{
    public class EntryReadRepository : ReadRepository<Entry>, IEntryReadRepository
    {
        public EntryReadRepository(DuvarAPIDbContext context) : base(context)
        {
        }
    }
}
