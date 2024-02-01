

using Library_Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library_DataAccessLayer.Configurations;

public class BookConfiguration : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.Property(b => b.Name).HasColumnType("nvarchar(100)").IsRequired(true);
        builder.Property(b => b.Pages).HasColumnType("int").IsRequired(true);
        builder.Property(b => b.YearPress).HasColumnType("int").IsRequired(true);
        builder.Property(b => b.CategoryId).HasColumnType("int").IsRequired(true);
        builder.Property(b => b.AuthorId).HasColumnType("int").IsRequired(true);
        builder.Property(b => b.Comment).HasColumnType("nvarchar(50)").IsRequired(true);
        builder.Property(b => b.Quantity).HasColumnType("int").IsRequired(true);
        builder.HasMany(b => b.SCards).WithOne(sc => sc.Book).HasForeignKey(sc => sc.BookId).OnDelete(DeleteBehavior.Cascade);
        builder.HasMany(b => b.TCards).WithOne(tc => tc.Book).HasForeignKey(tc => tc.BookId).OnDelete(DeleteBehavior.Cascade);
    }
}
