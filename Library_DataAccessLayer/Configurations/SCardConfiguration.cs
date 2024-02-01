
using Library_Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library_DataAccessLayer.Configurations;

public class SCardConfiguration : IEntityTypeConfiguration<SCard>
{
    public void Configure(EntityTypeBuilder<SCard> builder)
    {
        builder.HasKey(be => be.Id);
        builder.Property(be => be.Id).UseIdentityColumn().IsRequired(true);
        builder.Property(sc => sc.StudentId).IsRequired(true);
        builder.Property(sc => sc.BookId).IsRequired(true);
        builder.Property(sc => sc.DateOut).HasColumnType("datetime").IsRequired(true);
        builder.Property(sc => sc.DateIn).HasColumnType("datetime").IsRequired(false);

    }
}
