using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BE_4_customers.Models;
using Microsoft.EntityFrameworkCore;

namespace BE_4_customers.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Product> Product { get; set; }

    }
}
