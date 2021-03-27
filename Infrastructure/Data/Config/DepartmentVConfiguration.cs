using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config
{
    public class DepartmentVConfiguration : IEntityTypeConfiguration<DepartmentV>
    {
        public void Configure(EntityTypeBuilder<DepartmentV> builder)
        {
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Created).IsRequired();
        }
    }
}