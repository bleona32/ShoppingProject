using ShoppingProject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace ShoppingProject.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)

        {
        }
        //public DbSet<ShoppingProject.Models.News> News { get; set; }
        //protected override void OnModelCreating(ModelBuilder builder)
        // {
        //  base.OnModelCreating(builder);

    }
}
