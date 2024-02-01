
namespace Library_Model.Entities;

public class SCard : BaseEntity
{
    public int StudentId { get; set; }
    public virtual Student Student { get; set; }
    public int BookId { get; set; }
    public virtual Book Book { get; set; }
    public int LibId { get; set; }
    public virtual Lib Lib { get; set; }
    public DateTime DateOut { get; set; }
    public DateTime? DateIn { get; set; }

    public SCard()
    {
        
    }


}
