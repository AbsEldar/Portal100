using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config
{
    public class RegionConfiguration : IEntityTypeConfiguration<Region>
    {
        public void Configure(EntityTypeBuilder<Region> builder)
        {
            builder.Property(p => p.Id).IsRequired();
            builder.Property(p => p.NameEn).IsRequired().HasMaxLength(100);
            builder.Property(p => p.NameKz).IsRequired().HasMaxLength(100);
            builder.Property(p => p.NameRu).IsRequired().HasMaxLength(100);
        }
    }
}