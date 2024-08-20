using ITInventoryManagement.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ITInventoryManagement.Data
{
    public class DataContext : IdentityDbContext<AppUser>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var admin = new IdentityRole("Admin");
            admin.NormalizedName = "admin";

            var standart_account = new IdentityRole("Standart Account");
            standart_account.NormalizedName = "standart_account";

            var it_staff = new IdentityRole("IT Staff");
            admin.NormalizedName = "it_staff ";

            modelBuilder.Entity<IdentityRole>().HasData(admin, standart_account, it_staff);
        }
    }
}
