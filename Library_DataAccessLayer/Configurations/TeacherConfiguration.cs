

using Library_Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library_DataAccessLayer.Configurations;

public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
{
    public void Configure(EntityTypeBuilder<Teacher> builder)
    {
        builder.HasKey(t => t.Id);
        builder.Property(t => t.Id).UseIdentityColumn().IsRequired(true);
        builder.Property(t => t.FirstName).HasColumnType("nvarchar(20)").IsRequired(true);
        builder.Property(t => t.LastName).HasColumnType("nvarchar(25)").IsRequired(true);
        builder.HasMany(t => t.TCards).WithOne(tc => tc.Teacher).HasForeignKey(tc => tc.TeacherId).OnDelete(DeleteBehavior.Cascade);

    }
}
