using Microsoft.EntityFrameworkCore;
using MyBookList.Api.Entities;

namespace MyBookList.Api.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Book> Books => Set<Book>();

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Book>(e =>
            {
                e.HasKey(b => b.Id);

                e.Property(b => b.Title)
                    .IsRequired()
                    .HasMaxLength(200);
                
                e.Property(b => b.Author)
                    .IsRequired()
                    .HasMaxLength(150);

                e.Property(b => b.Status)
                    .HasConversion<string>()
                    .HasMaxLength(20);

                e.Property(b => b.Review)
                    .IsRequired()
                    .HasMaxLength(500);
            });
        }
    }
}
