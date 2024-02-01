

using Library_Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library_DataAccessLayer.Configurations;

public class LibConfiguration : IEntityTypeConfiguration<Lib>
{
    public void Configure(EntityTypeBuilder<Lib> builder)
    {
        builder.HasKey(l => l.Id);
        builder.Property(l => l.Id).UseIdentityColumn().IsRequired(true);
        builder.Property(l => l.FirstName).HasColumnType("nvarchar(10)").IsRequired(true);
        builder.Property(l => l.LastName).HasColumnType("nvarchar(15)").IsRequired(true);
        builder.HasMany(l => l.SCards).WithOne(sc => sc.Lib).HasForeignKey(sc => sc.LibId).OnDelete(DeleteBehavior.Cascade);
        builder.HasMany(l => l.TCards).WithOne(tc => tc.Lib).HasForeignKey(tc => tc.LibId).OnDelete(DeleteBehavior.Cascade);

    }
}
