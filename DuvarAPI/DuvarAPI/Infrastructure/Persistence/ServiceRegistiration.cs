using Application.Repositories.EntryRepository;
using Application.Repositories.UserRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Context;
using Persistence.EntryRepositoryConcrete;
using Persistence.Services;
using Persistence.UserRepositoryConcrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public static class ServiceRegistiration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<DuvarAPIDbContext>(options => options.UseSqlServer(Configuration.ConnectionString));
            services.AddScoped<IUserReadRepository,UserReadRepository>();
            services.AddScoped<IUserWriteRepository, UserWriteRepository>();
            services.AddScoped<IEntryWriteRepository, EntryWriteRepository>();
            services.AddScoped<IEntryReadRepository, EntryReadRepository>();
            services.AddScoped<IUserService, UserServices>();
            services.AddScoped<IEntryService, EntryService>();

        }
    }
}
