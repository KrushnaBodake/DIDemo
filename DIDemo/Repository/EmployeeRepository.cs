using DIDemo.Data;
using DIDemo.Models;

namespace DIDemo.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext db;
        public EmployeeRepository(ApplicationDbContext db) 
        {
            this.db = db;
        }
        public int AddEmployee(Employee emp)
        {
            int result = 0;
            db.Employees.Add(emp);
            result=db.SaveChanges();
            return result;
        }

        public int DeleteEmployee(int id)
        {
            int result = 0;
            var emp= db.Employees.Where(x => x.Empid == id).FirstOrDefault();
            if(emp!= null)
            {
                db.Remove(emp);
                result= db.SaveChanges();
            }
            return result;
        }

        public IEnumerable<Employee> GetAllEmploee()
        {
           return db.Employees.ToList();
        }

        public Employee GetEmployeeById(int id)
        {
           var emp= db.Employees.Where(x=>x.Empid==id).FirstOrDefault();
            return emp;
        }

        public int UpdateEmployee(Employee emp)
        {
            int result = 0;
            var e = db.Employees.Where(x => x.Empid == emp.Empid).FirstOrDefault();
            if(e!=null)
            {
                e.Empname= emp.Empname;
                e.Deptname= emp.Deptname;
                e.Salary = emp.Salary;
                e.Age = emp.Age;
                result= db.SaveChanges();
            }
            return result;
        }
        
    }
}
