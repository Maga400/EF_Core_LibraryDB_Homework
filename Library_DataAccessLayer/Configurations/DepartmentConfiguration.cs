

using Library_Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library_DataAccessLayer.Configurations;

public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
{
    public void Configure(EntityTypeBuilder<Department> builder)
    {
        builder.HasKey(d => d.Id);
        builder.Property(d => d.Id).UseIdentityColumn().IsRequired(true);
        builder.Property(d => d.Name).HasColumnType("nvarchar(25)").IsRequired(false);
        builder.HasMany(d => d.Teachers).WithOne(t => t.Department).HasForeignKey(t => t.DepartmentId).OnDelete(DeleteBehavior.Cascade);
    
    }

}

