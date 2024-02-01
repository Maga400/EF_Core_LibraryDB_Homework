

using Library_DataAccessLayer.Repostories.Abstracts;
using Library_Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace Library_DataAccessLayer.Repostories.Concretes;

public class SCardRepository : GenericRepository<SCard>, ISCardRepository
{
    public ICollection<SCard> GetAllWithBook()
    {
        return _context.S_Cards.Include(a => a.Book).ToList();
    }

    public ICollection<SCard> GetAllWithStudent()
    {
        return _context.S_Cards.Include(a => a.Student).ToList();
    }
}
