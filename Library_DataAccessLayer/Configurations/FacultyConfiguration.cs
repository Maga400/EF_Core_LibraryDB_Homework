

using Library_Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library_DataAccessLayer.Configurations;

public class FacultyConfiguration : IEntityTypeConfiguration<Faculty>
{
    public void Configure(EntityTypeBuilder<Faculty> builder)
    {
        builder.HasKey(f => f.Id);
        builder.Property(f => f.Id).UseIdentityColumn().IsRequired(true);
        builder.Property(f => f.Name).HasColumnType("nvarchar(15)").IsRequired(false);
        builder.HasMany(f => f.Groups).WithOne(g => g.Faculty).HasForeignKey(g => g.FacultyId).OnDelete(DeleteBehavior.Cascade);

    }
}
