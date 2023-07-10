using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using EmployeeManagement.DAL.Interface;
using EmployeeManagement.Model;
using EmployeeManagement.DAL.Repositary;

namespace EmployeeManagement.DAL.Repositary
{
    public class UserRepositary : BaseRepositary<UserModel>, IUserRepositary
    {
        public UserRepositary()
        {
            base.ConnectionString = base.GetConnectionString();
        }

        public List<UserModel> GetAllUsers()
        {
            try
            {
                var sqlParameters = new List<SqlParameter>();
                return this.ExecuteReader("[dbo].[GetAllUsers]", sqlParameters, MapUserDetailsModel, 90);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public int RegisterUser(UserModel userModel)
        {
            try
            {
                var sqlParameters = new List<SqlParameter>();
                sqlParameters.Add(new SqlParameter("@firstname", userModel.FirstName));
                sqlParameters.Add(new SqlParameter("@lastname", userModel.LastName));
                sqlParameters.Add(new SqlParameter("@email", userModel.Email));
                sqlParameters.Add(new SqlParameter("@password", userModel.Password));
                sqlParameters.Add(new SqlParameter("@gender", userModel.Gender));
                return this.ExecuteNonQuery("[dbo].[AddUser]", sqlParameters, 90);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int UserLogin(UserModel userModel)
        {
            try
            {
                var sqlParameters = new List<SqlParameter>();
                sqlParameters.Add(new SqlParameter("@email", userModel.Email));
                sqlParameters.Add(new SqlParameter("@password", userModel.Password));
                return this.ExecuteScalar<int>("[dbo].[UserLogin]", sqlParameters, 90);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int UserExists(UserModel userModel)
        {
            try
            {
                var sqlParameters = new List<SqlParameter>();
                sqlParameters.Add(new SqlParameter("@email", userModel.Email));
                return this.ExecuteScalar<int>("[dbo].[UserExists]", sqlParameters, 90);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public int GetUserId(UserModel userModel)
        {
            try
            {
                var sqlParameters = new List<SqlParameter>();
                sqlParameters.Add(new SqlParameter("@email", userModel.Email));
                return this.ExecuteScalar<int>("[dbo].[GetUserId]", sqlParameters, 90);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        protected void MapUserDetailsModel(UserModel userDetails, SqlDataReader dataReader, string[] columnNameList)
        {
            int UserIdIndex = this.GetColumnOrdinal(columnNameList, "UserId");
            if (UserIdIndex >= 0 && !dataReader.IsDBNull(UserIdIndex))
            {
                userDetails.UserId = dataReader.GetFieldValue<int>(UserIdIndex);
            }

            int UserFirstNameIndex = this.GetColumnOrdinal(columnNameList, "firstname");
            if (UserFirstNameIndex >= 0 && !dataReader.IsDBNull(UserFirstNameIndex))
            {
                userDetails.FirstName = dataReader.GetFieldValue<string>(UserFirstNameIndex);
            }

            int UserLastNameIndex = this.GetColumnOrdinal(columnNameList, "lastname");
            if (UserLastNameIndex >= 0 && !dataReader.IsDBNull(UserLastNameIndex))
            {
                userDetails.LastName = dataReader.GetFieldValue<string>(UserLastNameIndex);
            }

            int UserEmailIndex = this.GetColumnOrdinal(columnNameList, "email");
            if (UserEmailIndex >= 0 && !dataReader.IsDBNull(UserEmailIndex))
            {
                userDetails.Email = dataReader.GetFieldValue<string>(UserEmailIndex);
            }

            int UserPasswordIndex = this.GetColumnOrdinal(columnNameList, "password");
            if (UserPasswordIndex >= 0 && !dataReader.IsDBNull(UserPasswordIndex))
            {
                userDetails.Password = dataReader.GetFieldValue<string>(UserPasswordIndex);
            }

            int UserGenderIndex = this.GetColumnOrdinal(columnNameList, "gender");
            if (UserGenderIndex >= 0 && !dataReader.IsDBNull(UserGenderIndex))
            {
                userDetails.Gender = dataReader.GetFieldValue<string>(UserGenderIndex);
            }

        }
    }
}
