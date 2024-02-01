

namespace Library_Model.Entities;

public class Group : BaseEntity
{
    public string? Name { get; set; }
    public int FacultyId { get; set; }
    public virtual Faculty Faculty { get; set; }
    public virtual ICollection<Student> Students { get; set; }
    public Group() 
    {

    }

}
