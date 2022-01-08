using Ecommerce.Domain;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.DataAccess
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }

        public DbSet<ProductCategory> ProductCategories { get; set; }

    }
}
