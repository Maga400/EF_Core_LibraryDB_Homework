

using Library_Model.Entities;

namespace Library_DataAccessLayer.Repostories.Abstracts;

public interface IBookRepository : IGenericRepository<Book>
{
    int QuantitySUM();
    int MaxQuantity();
}
