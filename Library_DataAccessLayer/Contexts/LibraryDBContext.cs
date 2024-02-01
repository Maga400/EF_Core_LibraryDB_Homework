

using Library_Model.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Library_DataAccessLayer.Contexts;

internal class LibraryDBContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

        var str = @"Data Source=USER-PC\SQLEXPRESS;Initial Catalog=LibraryDB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;";
        optionsBuilder.UseLazyLoadingProxies().UseSqlServer(str);
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
    }

    public virtual DbSet<Author> Authors { get; set; }
    public virtual DbSet<Book> Books { get; set; }
    public virtual DbSet<Category> Categories { get; set; }
    public virtual DbSet<Department> Departments { get; set; }
    public virtual DbSet<Faculty> Faculties { get; set; }
    public virtual DbSet<Group> Groups { get; set; }
    public virtual DbSet<Lib> Libs { get; set; }
    public virtual DbSet<Pres> Pres { get; set; }
    public virtual DbSet<SCard> S_Cards { get; set; }
    public virtual DbSet<Student> Students { get; set; }
    public virtual DbSet<TCard> TCards { get; set; }
    public virtual DbSet<Teacher> Teachers { get; set; }
    public virtual DbSet<Theme> Themes { get; set; }

}
