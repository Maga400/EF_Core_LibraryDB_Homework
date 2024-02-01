

using Library_DataAccessLayer.Contexts;
using Library_DataAccessLayer.Repostories.Abstracts;
using Library_Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace Library_DataAccessLayer.Repostories.Concretes;

public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity, new()
{
    internal readonly LibraryDBContext _context;
    internal readonly DbSet<T> _entity;

    public GenericRepository()
    {
        _context = new LibraryDBContext();
        _entity = _context.Set<T>();
    }


    public void Add(T entity)
    {
        if (entity == null) throw new Exception("Entity Is NULL");
        _entity.Add(entity);
    }

    public ICollection<T> GetAll()
    {
        return _entity.ToList();
    }

    public T? GetById(int id)
    {
        return _entity.FirstOrDefault(a => a.Id == id);
    }

    public void Remove(T entity)
    {
        if (entity == null) throw new Exception("Entity Is NULL");

        var isChechk = _entity.FirstOrDefault(a => a.Id == entity.Id);

        if (isChechk == null) throw new Exception("Entity Not Found");
        _entity.Remove(entity);
    }

    public void Save()
    {
        _context.SaveChanges();
    }

    public void Update(T entity)
    {
        if (entity == null) throw new Exception("Entity Is NULL");

        var isChechk = _entity.FirstOrDefault(a => a.Id == entity.Id);

        if (isChechk == null) throw new Exception("Entity Not Found");


        _entity.Update(entity);
    }
}
