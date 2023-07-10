using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.Model;
using EmployeeManagment.BAL.Interface;
using EmployeeManagement.DAL.Interface;
namespace EmployeeManagment.BAL.Services
{
    public class UserServices: BaseService, IUserServices
    {
        private IUserRepositary _userRepository = UnitOfWorks.UserRepository;

        public List<UserModel> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }

        public int RegisterUser(UserModel userModel)
        {
            return _userRepository.RegisterUser(userModel);

        }
        public int UserLogin(UserModel userModel)
        {
            return _userRepository.UserLogin(userModel);
        }

        public int UserExists(UserModel userModel)
        {
            return _userRepository.UserExists(userModel);
        }

        public int GetUserId(UserModel userModel)
        {
            return _userRepository.GetUserId(userModel);
        }
    }
}
