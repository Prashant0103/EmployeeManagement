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
    public class UserController : BaseController
    {
        private IUserServices _userService = UnitOfWorks.UserServices;

        [HttpGet]
        public List<UserModel> GetAllUsers()
        {
            return _userService.GetAllUsers();
        }

        [HttpPost]
        public int SaveUser(UserModel userModel)
        {
            return _userService.RegisterUser(userModel);
        }

        [HttpPost]
        public int UserLogin(UserModel userModel)
        {
            return _userService.UserLogin(userModel);

        }

        [HttpPost]
        public int UserExists(UserModel userModel)
        {
            return _userService.UserExists(userModel);

        }

        [HttpPost]
        public int GetUserId(UserModel userModel)
        {
            return _userService.GetUserId(userModel);

        }
    }

}
