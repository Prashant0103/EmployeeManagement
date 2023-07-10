using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.Model;

namespace EmployeeManagement.DAL.Interface
{
    public interface IUserRepositary
    {
        List<UserModel> GetAllUsers();

        int RegisterUser(UserModel userModel);

        int UserLogin(UserModel userModel);

        int UserExists(UserModel userModel);

        int GetUserId(UserModel userModel);
    }
}
