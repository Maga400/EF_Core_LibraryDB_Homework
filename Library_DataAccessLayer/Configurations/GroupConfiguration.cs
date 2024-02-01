

using Library_Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library_DataAccessLayer.Configurations;

public class GroupConfiguration : IEntityTypeConfiguration<Group>
{
    public void Configure(EntityTypeBuilder<Group> builder)
    {
        builder.HasKey(g => g.Id);
        builder.Property(g => g.Id).UseIdentityColumn().IsRequired(true);
        builder.Property(g => g.Name).HasColumnType("nvarchar(15)").IsRequired(true);
        builder.HasMany(g => g.Students).WithOne(s => s.Group).HasForeignKey(g => g.GroupId).OnDelete(DeleteBehavior.Cascade);

    }
}
