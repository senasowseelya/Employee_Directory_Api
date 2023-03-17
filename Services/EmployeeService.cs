using Data;
using Models;
using System.Security.Cryptography;
using System.Data;
using System.Data.SqlClient;
using System.Reflection.PortableExecutable;
using EmployeeDirectory.API;

namespace Services
{
    public class EmployeeService : IEmployeeService
    {

        readonly EmployeeContext _employeeDBContext;
        public EmployeeService(EmployeeContext employeeDBContext)
        {
            _employeeDBContext = employeeDBContext;
        }
        public string AddEmployee(Employee employee)
        {
           
            _employeeDBContext.Employees.Add(employee);
            _employeeDBContext.SaveChanges();
            return employee.ID;
        }

        public List<Employee> GetAllEmployees()
        {
            return _employeeDBContext.Employees.ToList();
        }

        public Employee GetEmployee(string id)
        {
            return _employeeDBContext.Employees.FirstOrDefault(_ => _.ID == id);
        }

        public string RemoveEmployee(string id)
        {
            var emp = _employeeDBContext.Employees.FirstOrDefault(_ => _.ID == id);
            if (emp != null)
                _employeeDBContext.Employees.Remove(emp);
            _employeeDBContext.SaveChanges();
            return id;
        }

        public Employee UpdateEmployee(Employee employee)
        {
            var emp = _employeeDBContext.Employees.FirstOrDefault(_ => _.ID == employee.ID);
            if(emp != null)
                _employeeDBContext.Employees.Remove(emp);
            _employeeDBContext.Employees.Add(employee);
            _employeeDBContext.SaveChanges();
            return employee;
        }
    }
}