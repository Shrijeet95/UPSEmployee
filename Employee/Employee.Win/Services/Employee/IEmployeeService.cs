using Employee.Win.Models.Entity;
using Employee.Win.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Win.Services.Employee.Interface
{
    public interface IEmployeeService
    {
        Task<List<EmployeeView>> GetEmployees();
        Task<List<EmployeeView>> GetEmployeesByName(string employeeName);
        Task<List<EmployeeView>> GetEmployeesById(int id);
        Task<int> SetEmployee(EmployeeView employee);
        Task<int> PutEmployee(EmployeeView employee);
        Task<int> DelEmployee(int id);
    }
}
