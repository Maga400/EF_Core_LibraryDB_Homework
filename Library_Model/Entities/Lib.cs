
namespace Library_Model.Entities;

public class Lib : BaseEntity
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public virtual ICollection<SCard> SCards { get; set; }
    public virtual ICollection<TCard> TCards { get; set; }
    public Lib()
    {

    }

}
