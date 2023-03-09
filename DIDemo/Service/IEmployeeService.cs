using DIDemo.Models;

namespace DIDemo.Service
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetAllEmploee();
        Employee GetEmployeeById(int id);
        int AddEmployee(Employee emp);
        int UpdateEmployee(Employee emp);
        int DeleteEmployee(int id);
    }
}
