
using Library_Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library_DataAccessLayer.Configurations;

public class AuthorConfiguration : IEntityTypeConfiguration<Author>
{
    public void Configure(EntityTypeBuilder<Author> builder)
    {
        builder.HasKey(be => be.Id);
        builder.Property(be => be.Id).UseIdentityColumn().IsRequired(true);
        builder.Property(a => a.FirstName).HasColumnType("nvarchar(15)").IsRequired();
        builder.Property(a => a.LastName).HasColumnType("nvarchar(25)").IsRequired();
        builder.HasMany(a => a.Books).WithOne(b => b.Author).HasForeignKey(b => b.AuthorId).OnDelete(DeleteBehavior.Cascade);
   
    }
}
