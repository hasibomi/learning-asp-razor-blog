using Microsoft.EntityFrameworkCore;
using Blog.Models;

namespace Blog.Data
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext(
            DbContextOptions<BlogDbContext> options
        ) : base(options) {}

        public DbSet<User> User { get; set; }
        public DbSet<Post> Post { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasIndex(u => u.Username).IsUnique();
            modelBuilder.Entity<User>().HasIndex(u => u.Email).IsUnique();
        }
    }
}
