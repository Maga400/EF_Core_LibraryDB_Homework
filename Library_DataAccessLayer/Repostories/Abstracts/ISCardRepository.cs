

using Library_Model.Entities;

namespace Library_DataAccessLayer.Repostories.Abstracts;

public interface ISCardRepository : IGenericRepository<SCard>
{
    ICollection<SCard> GetAllWithBook();
    ICollection<SCard> GetAllWithStudent();
}
