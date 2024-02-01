

namespace Library_Model.Entities;

public class Pres : BaseEntity
{
    public string? Name { get; set; }
    public virtual ICollection<Book> Books { get; set; }
    public Pres()
    {
    
    }
}
