using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.KeyIndex).IsRequired().HasMaxLength(100);
            builder.HasMany(x => x.DepartmentVs).WithOne(x => x.Department).HasForeignKey(x => x.DepartmentId);
        }
    }
}