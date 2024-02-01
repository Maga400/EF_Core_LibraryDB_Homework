

using Library_Model.Entities;

namespace Library_DataAccessLayer.Repostories.Abstracts;

public interface  IGenericRepository<T> where T : BaseEntity, new()
{
    ICollection<T> GetAll();
    T? GetById(int id);
    void Add(T entity);
    void Update(T entity);
    void Remove(T entity);
    void Save();
}
