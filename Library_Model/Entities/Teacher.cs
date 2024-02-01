
namespace Library_Model.Entities;

public class Teacher : BaseEntity
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int DepartmentId { get; set; }
    public virtual Department Department { get; set; }
    public virtual ICollection<TCard> TCards { get; set; }
    public Teacher()
    {

    }

}
