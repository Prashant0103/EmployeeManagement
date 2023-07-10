using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagment.BAL.Services;

namespace EmployeeManagment.BAL.UOW
{
    public class UnitOfWork
    {
        private UserServices _userService;
        private EmployeeServices _employeeServices;
        public UserServices UserServices
        {
            get { return _userService ?? (_userService = new UserServices()); }
        }
        
        public EmployeeServices EmployeeServices
        {
            get { return _employeeServices ?? (_employeeServices = new EmployeeServices()); }
        }
    }
}
