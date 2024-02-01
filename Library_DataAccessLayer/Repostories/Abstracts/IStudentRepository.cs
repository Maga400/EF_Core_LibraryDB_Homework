

using Library_Model.Entities;

namespace Library_DataAccessLayer.Repostories.Abstracts;

public interface IStudentRepository : IGenericRepository<Student>
{
    int AllSurnameLength();
    public Student GetBySurName(string surname);
}
