

namespace Library_Model.Entities;

public class Student : BaseEntity
{
    public string? FirstName { get; set; }
    public string? LastName { get; set;}
    public int Term {  get; set; }
    public int GroupId { get; set; }
    public virtual Group Group { get; set; }
    public virtual ICollection<SCard> SCards { get; set; }
    public Student() 
    {
    
    }

}
