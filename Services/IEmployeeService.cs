using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IEmployeeService
    {
        List<Employee> GetAllEmployees();
        Employee GetEmployee(string id);
        string AddEmployee(Employee employee);
        Employee UpdateEmployee(Employee employee);
        string RemoveEmployee(string id);
       
         
            
    }
}
