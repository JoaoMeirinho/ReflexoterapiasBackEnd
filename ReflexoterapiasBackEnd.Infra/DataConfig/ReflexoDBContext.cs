using Microsoft.EntityFrameworkCore;
using ReflexoterapiasBackEnd.Domain.Entities;

namespace ReflexoterapiasBackEnd.Infra.DataConfig
{
    class ReflexoDBContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Client> Clients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ReflexoDBContext).Assembly);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.Enderecos)
                .WithOne(e => e.Client)
                .HasForeignKey(e => e.ClientId)
                .IsRequired();
        }

    }
}
