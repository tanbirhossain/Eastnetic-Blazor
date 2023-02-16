using Eastnetic.DAL.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eastnetic.DAL.Domain.Configuration
{
    public class WindowConfiguration : IEntityTypeConfiguration<Window>
    {
        public void Configure(EntityTypeBuilder<Window> builder)
        {
            builder.Property(p => p.Name)
                .HasMaxLength(100);
             //builder.Property(p => p.QuantityOfWindows)
             //   .IsRequired(false);
             //   builder.Property(p => p.TotalSubElements)
             //   .IsRequired(false);

            builder.HasOne(d => d.Order)
                 .WithMany(p => p.Windows)
                 .HasForeignKey(d => d.OrderId)
                 .HasConstraintName("FK_Window_Order");
        }
    }
}
