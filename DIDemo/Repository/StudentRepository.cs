using DIDemo.Data;
using DIDemo.Models;

namespace DIDemo.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext db;
        public StudentRepository(ApplicationDbContext db)
        {
            this.db = db;
        }

        public int AddStudent(Student stu)
        {
            int result = 0;
            db.Students.Add(stu);
            result= db.SaveChanges();
            return result;
        }

        public int DeleteStudent(int rollno)
        {
            int result = 0;
            var stu=db.Students.Where(x => x.Rollno == rollno).FirstOrDefault();
            if(stu!=null)
            {
                db.Students.Remove(stu); 
                db.SaveChanges();
            }
            return result;
        }

        public IEnumerable<Student> GetAllStudent()
        {
            return db.Students.ToList();
        }

        public Student GetStudentByRollno(int rollno)
        {
            var stu=db.Students.Where(x=>x.Rollno==rollno).FirstOrDefault();
            return stu;
        }

        public int UpdateStudent(Student stu)
        {
            int result = 0;
            var s=db.Students.Where(x => x.Rollno == stu.Rollno).FirstOrDefault();
            if(s!=null)
            {
                s.Name = stu.Name;
                s.Stream = stu.Stream;
                s.Percentage = stu.Percentage;
                s.Age = stu.Age;
                s.Gender = stu.Gender;
                result= db.SaveChanges();
            }
            return result;
        }
    }
}
