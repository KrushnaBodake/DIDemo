using DIDemo.Models;
using DIDemo.Repository;

namespace DIDemo.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository repo;
        public EmployeeService(IEmployeeRepository repo)
        {
            this.repo = repo;
        }

        public int AddEmployee(Employee emp)
        {
           return repo.AddEmployee(emp);

        }

        public int DeleteEmployee(int id)
        {
            return repo.DeleteEmployee(id);
        }

        public IEnumerable<Employee> GetAllEmploee()
        {
            return repo.GetAllEmploee();
        }

        public Employee GetEmployeeById(int id)
        {
            return repo.GetEmployeeById(id);
        }

        public int UpdateEmployee(Employee emp)
        {
            return repo.UpdateEmployee(emp);
        }
    }
}
