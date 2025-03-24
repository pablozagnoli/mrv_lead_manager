using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace MyApp.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<LeadsEntity> Leads { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LeadsEntity>(entity =>
            {
                entity.ToTable("leads");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.category).HasMaxLength(100);
                entity.Property(e => e.name).HasMaxLength(100);
                entity.Property(e => e.SubBurd).HasMaxLength(100);
                entity.Property(e => e.description).HasMaxLength(250);
                entity.Property(e => e.Price);
            });
        }
    }
}
