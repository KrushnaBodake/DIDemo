using DIDemo.Models;
namespace DIDemo.Repository
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmploee();
        Employee GetEmployeeById(int id);
        int AddEmployee(Employee emp);
        int UpdateEmployee(Employee emp);
        int DeleteEmployee(int id);
    }
} 
