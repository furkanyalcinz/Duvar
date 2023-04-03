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
    public class EntryWriteRepository : RepositoryWrite<Entry>, IEntryWriteRepository
    {
        public EntryWriteRepository(DuvarAPIDbContext context) : base(context)
        {
        }
    }
}
