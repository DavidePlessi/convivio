using System;
using Convivio.API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Convivio.API.Services
{
    public class Repository : DbContext
    {
        public DbSet<Roommate> Roommates { get; set; }

        public Repository(DbContextOptions options) : base(options)
        {
        }
    }
}