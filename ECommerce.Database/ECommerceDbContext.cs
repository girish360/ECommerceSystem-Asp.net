using ECommerce.Entitiess;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Database
{
    public class ECommerceDbContext : DbContext , IDisposable
    {
        public ECommerceDbContext()
            : base("MyDbConnection")
        {

        }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }
    }
}
