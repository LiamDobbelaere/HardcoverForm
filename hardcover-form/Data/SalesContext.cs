using hardcover_form.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hardcover_form.Data
{
    public class SalesContext : DbContext
    {
        public static void Initialize(SalesContext context)
        {
            context.Database.EnsureCreated();
        }

        public SalesContext(DbContextOptions<SalesContext> options) : base(options)
        {
        }

        public DbSet<SalesForm> SalesForms { get; set; }
    }
}
