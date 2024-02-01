
using Library_DataAccessLayer.Repostories.Abstracts;
using Library_Model.Entities;

namespace Library_DataAccessLayer.Repostories.Concretes;

public class AuthorRepository : GenericRepository<Author>, IAuthorRepository
{
    public int AuthorsCount()
    {
        return _context.Authors.Count();
    }

    public void ShowAuthors()
    {
        foreach (var author in _context.Authors) 
        {
            Console.WriteLine(author.Id + " " + author.FirstName + " " + author.LastName);
        }
    }
}
