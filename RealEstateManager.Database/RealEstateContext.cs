using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using RealEstateManager.Database.Models;

namespace RealEstateManager.Database
{
    public class RealEstateContext : DbContext
    {
        public RealEstateContext(DbContextOptions<RealEstateContext> options)
            :base(options)
        {
        }

        public DbSet<Property> Properties { get; set; }
        public DbSet<Payment> Payments { get; set; }

    }
}
