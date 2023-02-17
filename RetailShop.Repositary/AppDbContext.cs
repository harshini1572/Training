using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RetailShop.Repositary.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailShop.Repositary
{
    public class AppDbContext : DbContext
    {
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
            public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get;set; }
    }
}

