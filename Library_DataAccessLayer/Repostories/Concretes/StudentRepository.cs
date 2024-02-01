

using Library_DataAccessLayer.Repostories.Abstracts;
using Library_Model.Entities;

namespace Library_DataAccessLayer.Repostories.Concretes;

public class StudentRepository : GenericRepository<Student> , IStudentRepository
{
    int IStudentRepository.AllSurnameLength()
    {
        int sum = 0;
        foreach (var student in _context.Students)
        {
            sum += student.LastName.Length;
        }
        return sum;
    }
    public Student GetBySurName(string surname)
    {
        return _entity.FirstOrDefault(a => a.LastName == surname);
    }

}
