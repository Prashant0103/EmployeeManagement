using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EmployeeManagment.BAL.Interface;
using EmployeeManagement.Model;

namespace EmployeeManagement.API.Controllers
{
    public class EmployeeController : BaseController
    {
        private IEmployeeServices _employeeService = UnitOfWorks.EmployeeServices;

        [HttpGet]
        public List<EmployeeModel> GetAllEmployees()
        {
            return _employeeService.GetAllEmployees();
        }


        [HttpGet]
        [Route("api/Employee/GetEmployeePageData/{pageNumber}/{pageSize}")]
        public List<EmployeeModel> GetEmployeePageData(int pageNumber, int pageSize)
        {
            return _employeeService.GetEmployeePageData(pageNumber, pageSize);
        }

        [HttpGet]
        public EmployeeModel GetEmployeeById(int id)
        {
            return _employeeService.GetEmployeeById(id);
        }

        [HttpGet]
        public List<EmployeeModel> GetSearchedEmployee(string search)
        {
            return _employeeService.GetSearchedEmployee(search);
        }

        [HttpPost]
        public int SaveEmployee(EmployeeModel employee)
        {
            return _employeeService.SaveEmployee(employee);
        }

        [HttpPut]
        public int UpdateEmployee(int id, EmployeeModel employee)
        {
            return _employeeService.UpdateEmployee(id, employee);
        }

        [HttpDelete]
        public int DeleteEmployee(int id)
        {
            return _employeeService.DeleteEmployee(id);
        }
    }
}
