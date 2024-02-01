
namespace Library_Model.Entities;

public class Theme : BaseEntity
{
    public string? Name { get; set; }
    public virtual ICollection<Book> Books { get; set; }
    public Theme()
    {

    }
}
