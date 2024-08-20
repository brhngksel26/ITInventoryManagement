using ITInventoryManagement.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ITInventoryManagement.Data
{
    public class DataContext : IdentityDbContext<AppUser>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<InventoryItem> InventoryItems { get; set; }
        public DbSet<Category> Categories { get; set; }

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

            modelBuilder.Entity<Category>().HasData(
                 new Category { Id = 1, Name = "Laptops", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                 new Category { Id = 2, Name = "Monitors", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                 new Category { Id = 3, Name = "Keyboards", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                 new Category { Id = 4, Name = "Mice", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now }
            );

            modelBuilder.Entity<InventoryItem>().HasData(
                new InventoryItem
                {
                    Id = 1,
                    Name = "Dell XPS 13",
                    SerialNumber = "DXPS13-001",
                    Model = "XPS 13",
                    Brand = "Dell",
                    StockQuantity = 5,
                    PurchaseDate = DateTime.Now.AddMonths(-12),
                    WarrantyExpiryDate = DateTime.Now.AddMonths(12),
                    CategoryId = 1,
                    IsAssigned = false,
                    IsLoaned = false,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new InventoryItem
                {
                    Id = 2,
                    Name = "Samsung UltraWide Monitor",
                    SerialNumber = "SUM-002",
                    Model = "UltraWide 49",
                    Brand = "Samsung",
                    StockQuantity = 3,
                    PurchaseDate = DateTime.Now.AddMonths(-10),
                    WarrantyExpiryDate = DateTime.Now.AddMonths(14),
                    CategoryId = 2,
                    IsAssigned = false,
                    IsLoaned = false,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new InventoryItem
                {
                    Id = 3,
                    Name = "Logitech MX Master 3",
                    SerialNumber = "LMXM3-003",
                    Model = "MX Master 3",
                    Brand = "Logitech",
                    StockQuantity = 10,
                    PurchaseDate = DateTime.Now.AddMonths(-8),
                    WarrantyExpiryDate = DateTime.Now.AddMonths(16),
                    CategoryId = 4,
                    IsAssigned = false,
                    IsLoaned = false,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                }
            );
        }
    }
}
