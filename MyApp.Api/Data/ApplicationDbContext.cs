using Microsoft.EntityFrameworkCore;
using MyApp.Api.Models;

namespace MyApp.Api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostMetadata> PostMetadatas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Явно указываем связь 1-to-1 между Post и PostMetadata
            modelBuilder.Entity<Post>()
                .HasOne(p => p.PostMetadata)
                .WithOne(pm => pm.Post)
                .HasForeignKey<PostMetadata>(pm => pm.PostId);

            // Связь 1-to-many между Author и Post EF Core обычно определяет
            // автоматически по конвенции (AuthorId + Author + List<Post>),
            // но можно указать явно для ясности:
            modelBuilder.Entity<Post>()
                .HasOne(p => p.Author)
                .WithMany(a => a.Posts)
                .HasForeignKey(p => p.AuthorId);
        }
    }
}