using BarberShop.Models;
using Microsoft.EntityFrameworkCore;

namespace BarberShop.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        //Data Models
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Guest> Guests { get; set; }

        //Seeding Data
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Profile>().HasData(
                new Profile
                {
                    Id = 1,
                    Name = "John",
                    Option1 = "Haircut1",
                    Option2 = "Haircut2",
                    Option3 = "Haircut3",
                    Option4 = "Haircut4",
                });
        }
    }
}
