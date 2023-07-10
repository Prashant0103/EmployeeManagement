using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.DAL.Repositary;

namespace EmployeeManagement.DAL.UOW
{
    public class UnitOfWork
    {
        private UserRepositary _userRepository;

        private EmployeeRepositary _employeeRepositary;
        public UserRepositary UserRepository
        {
            get { return _userRepository ?? (_userRepository = new UserRepositary()); }
        }

        public EmployeeRepositary EmployeeRepositary
        {
            get { return _employeeRepositary ?? (_employeeRepositary = new EmployeeRepositary()); }
        }
    }
}
