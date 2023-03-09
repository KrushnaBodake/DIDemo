using DIDemo.Models;

namespace DIDemo.Repository
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAllStudent();
        Student GetStudentByRollno(int rollno);
        int AddStudent(Student stu);
        int UpdateStudent(Student student);
        int DeleteStudent(int rollno);
    }
}
