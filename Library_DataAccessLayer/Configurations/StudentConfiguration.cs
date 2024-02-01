

using Library_Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library_DataAccessLayer.Configurations;

public class StudentConfiguration : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder.HasKey(be => be.Id);
        builder.Property(be => be.Id).UseIdentityColumn().IsRequired(true);
        builder.Property(s => s.FirstName).HasColumnType("nvarchar(15)").IsRequired(true);
        builder.Property(s => s.LastName).HasColumnType("nvarchar(25)").IsRequired(true);
        builder.Property(s => s.Term).HasColumnType("int").IsRequired(true);
        builder.HasMany(s => s.SCards).WithOne(sc => sc.Student).HasForeignKey(sc => sc.StudentId).OnDelete(DeleteBehavior.Cascade);
    
    }
}
