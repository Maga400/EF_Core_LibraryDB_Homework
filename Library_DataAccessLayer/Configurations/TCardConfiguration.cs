

using Library_Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library_DataAccessLayer.Configurations;

public class TCardConfiguration : IEntityTypeConfiguration<TCard>
{
    public void Configure(EntityTypeBuilder<TCard> builder)
    {
        builder.HasKey(tc => tc.Id);
        builder.Property(tc => tc.Id).UseIdentityColumn().IsRequired(true);
        builder.Property(tc => tc.TeacherId).IsRequired(true);
        builder.Property(tc => tc.BookId).IsRequired(true);
        builder.Property(tc => tc.LibId).IsRequired(true);
        builder.Property(tc => tc.DateOut).HasColumnType("datetime").IsRequired(true);
        builder.Property(tc => tc.DateIn).HasColumnType("datetime").IsRequired(true);

    }
}
