

using Library_DataAccessLayer.Repostories.Abstracts;
using Library_Model.Entities;

namespace Library_DataAccessLayer.Repostories.Concretes;

public class BookRepository : GenericRepository<Book>, IBookRepository
{
    public int MaxQuantity()
    {
        int MAX = 0;
        foreach (var book in _context.Books) 
        {
            if(book.Quantity > MAX) 
            {
                MAX = book.Quantity;
            
            }
        }
        return MAX;
    }

    public int QuantitySUM()
    {
        int sum = 0;
        foreach (var book in _context.Books)
        {
            sum += book.Quantity;
        }
        return sum;
    }
}
