using Eastnetic.DAL.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eastnetic.DAL.Domain
{
    public class EastneticDbContext : DbContext
    {
        public EastneticDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EastneticDbContext).Assembly);

            modelBuilder.Entity<Order>().ToTable("Order");
        }
        public virtual DbSet<Order> Orders { get; set; }

    }
}
