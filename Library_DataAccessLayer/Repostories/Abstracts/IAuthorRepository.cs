

using Library_Model.Entities;

namespace Library_DataAccessLayer.Repostories.Abstracts;

public interface IAuthorRepository : IGenericRepository<Author>
{
    void ShowAuthors();
    int AuthorsCount();
}
