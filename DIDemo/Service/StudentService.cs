using DIDemo.Models;
using DIDemo.Repository;

namespace DIDemo.Service
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository repo;
        public StudentService(IStudentRepository repo)
        {
            this.repo = repo;
        }

        public int AddStudent(Student stu)
        {
            return repo.AddStudent(stu);
        }

        public int DeleteStudent(int rollno)
        {
            return repo.DeleteStudent(rollno);
        }

        public IEnumerable<Student> GetAllStudent()
        {
            return repo.GetAllStudent();
        }

        public Student GetStudentByRollno(int rollno)
        {
            return repo.GetStudentByRollno(rollno);
        }

        public int UpdateStudent(Student stu)
        {
            return repo.UpdateStudent(stu);
        }
    }
}
