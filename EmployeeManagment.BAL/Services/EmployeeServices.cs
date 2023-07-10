using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagment.BAL.Interface;
using EmployeeManagement.Model;
using EmployeeManagement.DAL.Interface;

namespace EmployeeManagment.BAL.Services
{
    public class EmployeeServices : BaseService, IEmployeeServices
    {
        private IEmployeeRepositary _employeeRepository = UnitOfWorks.EmployeeRepositary;

        public List<EmployeeModel> GetAllEmployees()
        {
            return _employeeRepository.GetAllEmployees();
        }


        public List<EmployeeModel> GetEmployeePageData(int pageNumber, int pageSize)
        {
            return _employeeRepository.GetEmployeePageData(pageNumber, pageSize);
        }

        public EmployeeModel GetEmployeeById(int id)
        {
            return _employeeRepository.GetEmployeeById(id);
        }

        public List<EmployeeModel> GetSearchedEmployee(string search)
        {
            return _employeeRepository.GetSearchedEmployee(search);
        }
        public int SaveEmployee(EmployeeModel employee)
        {
            return _employeeRepository.SaveEmployee(employee);
        }

        public int UpdateEmployee(int id, EmployeeModel employee)
        {
            return _employeeRepository.UpdateEmployee(id, employee);
        }

        public int DeleteEmployee(int id)
        {
            return _employeeRepository.DeleteEmployee(id);
        }
    }
}

