using Eastnetic.DAL.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eastnetic.DAL.Domain.Configuration
{
    public class SubElementConfiguration : IEntityTypeConfiguration<SubElement>
    {
        public void Configure(EntityTypeBuilder<SubElement> builder)
        {
            builder.Property(p => p.Type)
                .HasMaxLength(100);

            builder.HasOne(d => d.Window)
                 .WithMany(p => p.SubElements)
                 .HasForeignKey(d => d.WindowId)
                 .HasConstraintName("FK_SubElement_Window");
        }
    }
}
