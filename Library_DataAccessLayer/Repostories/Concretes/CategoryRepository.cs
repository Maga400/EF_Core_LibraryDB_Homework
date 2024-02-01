

using Library_DataAccessLayer.Repostories.Abstracts;
using Library_Model.Entities;

namespace Library_DataAccessLayer.Repostories.Concretes;

public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
{
    public Category GetByName(string name)
    {
        return _entity.FirstOrDefault(a => a.Name == name);
    }
    int ICategoryRepository.AllNameLength()
    {
        int sum = 0;
        foreach (var book in _context.Categories)
        {
            sum += book.Name.Length;
        }
        return sum;
    }
}
