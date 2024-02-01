
namespace Library_Model.Entities;

public class Book : BaseEntity
{
    public string? Name { get; set; }
    public int Pages { get; set; }
    public int YearPress {  get; set; }
    public int ThemeId { get; set; }
    public virtual Theme Theme { get; set; }
    public int CategoryId { get; set; }
    public virtual Category Category { get; set; }
    public int AuthorId { get; set; }
    public virtual Author Author { get; set; }
    public int PresId { get; set; }
    public virtual Pres Pres { get; set; }
    public string Comment { get; set; }
    public int Quantity { get; set; }
    public virtual ICollection<SCard> SCards { get; set; }
    public virtual ICollection<TCard> TCards { get; set; }
    public Book()
    {
    
    }
}
