

using Library_Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library_DataAccessLayer.Configurations;

public class ThemeConfiguration : IEntityTypeConfiguration<Theme>
{
    public void Configure(EntityTypeBuilder<Theme> builder)
    {
        builder.HasKey(t => t.Id);
        builder.Property(t => t.Id).UseIdentityColumn().IsRequired(true);
        builder.Property(t => t.Name).HasColumnType("nvarchar(20)").IsRequired(true);
        builder.HasMany(t => t.Books).WithOne(b => b.Theme).HasForeignKey(b => b.ThemeId).OnDelete(DeleteBehavior.Cascade);

    }
}
