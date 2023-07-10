using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.Model;

namespace EmployeeManagment.BAL.Interface
{
    public interface IEmployeeServices
    {
        List<EmployeeModel> GetAllEmployees();

        List<EmployeeModel> GetEmployeePageData(int pageNumber, int pageSize);

        EmployeeModel GetEmployeeById(int id);

        List<EmployeeModel> GetSearchedEmployee(string search);

        int SaveEmployee(EmployeeModel employee);

        int UpdateEmployee(int id, EmployeeModel employee);

        int DeleteEmployee(int id);

    }
}
