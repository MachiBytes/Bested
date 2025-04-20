// Bested.Infrastructure\Persistence\AppDbContext.cs
using Bested.Domain.Entities;
using Bested.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Bested.Infrastructure.Persistence
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext (options)
    {
        internal DbSet<User> Users {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
    }
}
