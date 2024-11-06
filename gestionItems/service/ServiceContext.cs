using gestionItems.Models.data;
using Microsoft.EntityFrameworkCore;

namespace gestionItems.service
{
    public class ServiceContext : DbContext
    {
        public ServiceContext(DbContextOptions<ServiceContext> options)
            : base(options)
        {
        }

        public DbSet<Item> Items { get; set; } // Esta propiedad representa la tabla de ítems en la base de datos

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configura tu modelo aquí si es necesario
            modelBuilder.Entity<Item>()
                .Property(i => i.Title)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
