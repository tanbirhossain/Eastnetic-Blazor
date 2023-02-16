using Eastnetic.DAL.Domain.Configuration;
using Eastnetic.DAL.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
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
            //modelBuilder.ApplyConfigurationsFromAssembly(typeof(OrderConfiguration).Assembly);
            //modelBuilder.ApplyConfigurationsFromAssembly(typeof(WindowConfiguration).Assembly);
            //modelBuilder.ApplyConfigurationsFromAssembly(typeof(SubElementConfiguration).Assembly);
            new OrderConfiguration().Configure(modelBuilder.Entity<Order>());
            new WindowConfiguration().Configure(modelBuilder.Entity<Window>());
            new SubElementConfiguration().Configure(modelBuilder.Entity<SubElement>());


            modelBuilder.Entity<Order>().ToTable("Order");
            modelBuilder.Entity<Window>().ToTable("Window");
            modelBuilder.Entity<SubElement>().ToTable("SubElement");
            
        }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Window> Windows { get; set; }
        public virtual DbSet<SubElement> SubElements { get; set; }

    }
}
