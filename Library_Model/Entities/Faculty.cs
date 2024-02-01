

namespace Library_Model.Entities;

public class Faculty : BaseEntity
{
    public string? Name { get; set;}
    public virtual ICollection<Group> Groups { get; set;}
    public Faculty() 
    {
    
    }

}
