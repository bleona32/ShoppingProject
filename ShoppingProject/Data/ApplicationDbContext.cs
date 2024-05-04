
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShoppingProject.Models;

namespace ShoppingProject.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)

        {
        }
        public DbSet<ShoppingProject.Models.News> News { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Message>()
                .HasOne<AppUser>(a => a.Sender)
                .WithMany(d => d.Messages)
                .HasForeignKey(d => d.UserID);
        }

        public DbSet<Message> Messages { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Post> Posts { get; set; }


        public DbSet<Warranty> Warranties { get; set; }
        public DbSet<UserPostLike> UserPostLikes { get; set; }
        public DbSet<ShoppingProject.Models.Meeting> Meeting { get; set; }

        public DbSet<ShoppingProject.Models.Favorite> Favorites { get; set; }

    }
}
