using Microsoft.EntityFrameworkCore;
using ReflexoterapiasBackEnd.Domain.Entities;

namespace ReflexoterapiasBackEnd.Infra.DataConfig
{
    class ReflexoDBContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ReflexoDBContext).Assembly);
        }

    }
}
