using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebShop.Models;

namespace WebShop.Areas.Identity.Data;

public class AppDbContext : IdentityDbContext<ApplicationUser>
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        var hasher = new PasswordHasher<IdentityUser>();
        builder.Entity<ApplicationUser>().HasData(
            new ApplicationUser
            {
                UserName="Owner", 
                NormalizedUserName="OWNER" , 
                Email="kalle@havenoemail.com", 
                NormalizedEmail="KALLE@HAVENOEMAIL.COM", 
                FirstName="Karl", 
                LastName="Karlsson", 
                IsAdmin=true, 
                EmailConfirmed=true, 
                SecurityStamp=Guid.NewGuid().ToString("D"),
                PasswordHash = hasher.HashPassword(null, "test123")
            },
            new ApplicationUser
            {
                Id="1",
                UserName = "User",
                NormalizedUserName = "USER",
                Email = "jens@havenoemail.com",
                NormalizedEmail = "JENS@HAVENOEMAIL.COM",
                FirstName = "Jens",
                LastName = "Jensson",
                IsAdmin = false,
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString("D"),
                PasswordHash = hasher.HashPassword(null, "test123")
            });
        var ProductId1 = Guid.NewGuid();
        var ProductId2 = Guid.NewGuid();
        var ProductId3 = Guid.NewGuid();
        builder.Entity<Product>().HasData(
            new Product { ProductId = ProductId1 ,ProductName = "Pepsi", ProductPrice = 10, ProductDisctiption = "Drink" },
            new Product { ProductId = ProductId2 ,ProductName = "Pork", ProductPrice = 97, ProductDisctiption = "Meat" },
            new Product { ProductId = ProductId3 , ProductName = "Apple", ProductPrice = 3, ProductDisctiption = "Fruit" });

        builder.Entity<Order>().HasData(
            new Order { OrderId = 1, OrderedAt = DateTime.Now, Adress = "testvägen1", City = "teststaden", ZipCode = "123 45", UserId = "1" },
            new Order { OrderId = 2, OrderedAt = DateTime.Now, Adress = "testvägen1", City = "teststaden", ZipCode = "123 45", UserId = "1" },
            new Order { OrderId = 3, OrderedAt = DateTime.Now, Adress = "testvägen1", City = "teststaden", ZipCode = "123 45", UserId = "1" }
            );

        builder.Entity<OrderDetail>().HasData(
            new OrderDetail { OrderDetailId = 1, OrderId = 1, ProductId = ProductId1, ProductQuantity = 2 },
            new OrderDetail { OrderDetailId = 2, OrderId = 1, ProductId = ProductId2, ProductQuantity = 5 },
            new OrderDetail { OrderDetailId = 3, OrderId = 1, ProductId = ProductId3, ProductQuantity = 4 },
            new OrderDetail { OrderDetailId = 4, OrderId = 2, ProductId = ProductId1, ProductQuantity = 1 },
            new OrderDetail { OrderDetailId = 5, OrderId = 3, ProductId = ProductId3, ProductQuantity = 3 }
            );

        
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
        builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());
    }

    public DbSet<Product> Products { get; set; }//=> Set<Product>();
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }
}


public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<ApplicationUser>
{
    public void Configure(EntityTypeBuilder<ApplicationUser> builder)
    {
        builder.Property(u => u.FirstName).HasMaxLength(255);
        builder.Property(u => u.FirstName).HasMaxLength(255);
    }

    
}