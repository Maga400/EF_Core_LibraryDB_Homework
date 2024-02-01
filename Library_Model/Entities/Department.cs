
namespace Library_Model.Entities;

public class Department : BaseEntity
{
    public string? Name { get; set; }
    public virtual ICollection<Teacher> Teachers { get; set; }
    public Department() 
    {
    
    }

}
