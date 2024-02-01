

using Library_Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library_DataAccessLayer.Configurations;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.HasKey(be => be.Id);
        builder.Property(be => be.Id).UseIdentityColumn().IsRequired(true);
        builder.Property(c => c.Name).HasColumnType("nvarchar(30)").IsRequired(true);
        builder.HasMany(c => c.Books).WithOne(b => b.Category).HasForeignKey(b => b.CategoryId).OnDelete(DeleteBehavior.Cascade);
    
    }
}
