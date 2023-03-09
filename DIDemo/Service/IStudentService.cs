using DIDemo.Models;

namespace DIDemo.Service
{
    public interface IStudentService
    {
        IEnumerable<Student> GetAllStudent();
        Student GetStudentByRollno(int rollno);
        int AddStudent(Student stu);
        int UpdateStudent(Student student);
        int DeleteStudent(int rollno);
    }
}
