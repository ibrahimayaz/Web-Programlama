using Microsoft.EntityFrameworkCore;

namespace ETicaret.Models
{
    public class MyDbContext:DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> o):base(o)
        {

        }

        public DbSet<Product> Product { get; set; }
    }
}
