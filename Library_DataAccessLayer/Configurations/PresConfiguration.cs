

using Library_Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library_DataAccessLayer.Configurations;

public class PresConfiguration : IEntityTypeConfiguration<Pres>
{
    public void Configure(EntityTypeBuilder<Pres> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Id).UseIdentityColumn().IsRequired(true);
        builder.Property(p => p.Name).HasColumnType("nvarchar(20)").IsRequired(true);
        builder.HasMany(p => p.Books).WithOne(b => b.Pres).HasForeignKey(b => b.PresId).OnDelete(DeleteBehavior.Cascade);

    }
}
