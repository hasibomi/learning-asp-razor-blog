using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Blog.Models;

namespace Blog.Data
{
    public class BlogDbContext : IdentityDbContext<User, IdentityRole<Guid>, Guid>
    {
        public BlogDbContext(
            DbContextOptions<BlogDbContext> options
        ) : base(options) { }

        public DbSet<User> User { get; set; }
        public DbSet<Post> Post { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().HasIndex(u => u.UserName).IsUnique();
            modelBuilder.Entity<User>().HasIndex(u => u.Email).IsUnique();
            modelBuilder.Entity<User>().Property(u => u.UserName)
                .HasMaxLength(255);
            modelBuilder.Entity<User>().Property(u => u.Email)
                .HasMaxLength(255);
            modelBuilder.Entity<User>().Property(u => u.NormalizedUserName)
                .HasMaxLength(255);
            modelBuilder.Entity<User>().Property(u => u.NormalizedEmail)
                .HasMaxLength(255);
            modelBuilder.Entity<IdentityRole>().Property(r => r.Name)
                .HasMaxLength(255);
            modelBuilder.Entity<IdentityRole>().Property(r => r.NormalizedName)
                .HasMaxLength(255);
            //modelBuilder.Entity<IdentityUserLogin<string>>().Property(r => r.LoginProvider)
            //    .HasMaxLength(255);
            //modelBuilder.Entity<IdentityUserLogin<string>>().Property(r => r.ProviderKey)
            //    .HasMaxLength(255);
        }
    }
}
