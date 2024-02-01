

using Library_Model.Entities;

namespace Library_DataAccessLayer.Repostories.Abstracts;

public interface ICategoryRepository : IGenericRepository<Category>
{
    Category GetByName(string name);
    int AllNameLength();

}
