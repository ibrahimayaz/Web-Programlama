using ETicaret.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace ETicaret.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> o) : base(o)
        {

        }

        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Category>().HasData(
            //new Category
            //{
            //    Id = 1, Name = "Elektronik"
            //},
            //new Category
            //{
            //    Id = 2,
            //    Name = "Gıda"
            //},
            //new Category
            //{
            //    Id = 3,
            //    Name = "Tekstil"
            //});

            //modelBuilder.Entity<Product>().HasData(
            //    new Product
            //    {
            //        Id=1,
            //        Name = "Iphone 15 Pro Max",
            //        Description = "Amerikan Ürünü BOYKOTLUDUR.",
            //        Quantity = 10,
            //        CategoryId = 1
            //    },
            //    new Product
            //    {
            //        Id = 2,
            //        Name = "Kazak",
            //        Description = "Kışlık kazak",
            //        Quantity = 10,
            //        CategoryId = 3
            //    },
            //    new Product
            //    {
            //        Id = 3,
            //        Name = "Xioami Mi 10T Pro",
            //        Description = "Çin ürünüdür.",
            //        Quantity = 10,
            //        CategoryId = 1
            //    },
            //    new Product
            //    {
            //        Id = 4,
            //        Name = "Yağ 5 LT",
            //        Description = "Çin ürünüdür.",
            //        Quantity = 10,
            //        CategoryId = 2
            //    });
        }
    }
}
