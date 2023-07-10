using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.Model;
using EmployeeManagement.DAL.Interface;
using System.Data.SqlClient;

namespace EmployeeManagement.DAL.Repositary
{
    public class EmployeeRepositary : BaseRepositary<EmployeeModel>, IEmployeeRepositary
    {
        List<EmployeeModel> employeeModel = new List<EmployeeModel>();

        public EmployeeRepositary()
        {
            base.ConnectionString = base.GetConnectionString();
        }


        public List<EmployeeModel> GetAllEmployees()
        {
            try
            {
                var sqlParameters = new List<SqlParameter>();
                return this.ExecuteReader("[dbo].[GetAllEmployees]", sqlParameters, MapEmployeeDetailsModel, 90);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public EmployeeModel GetEmployeeById(int id)
        {
            try
            {
                var sqlParameters = new List<SqlParameter>();
                sqlParameters.Add(new SqlParameter("@eid", id));
                return this.ExecuteReader("[dbo].[GetEmployeeById]", sqlParameters, MapEmployeeDetailsModel, 90).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<EmployeeModel> GetEmployeePageData(int pageNumber, int pageSize)
        {
            try
            {
                var sqlParameters = new List<SqlParameter>();
                sqlParameters.Add(new SqlParameter("@PageNumber", pageNumber));
                sqlParameters.Add(new SqlParameter("@PageSize", pageSize));
                return this.ExecuteReader("[dbo].[GetPaginatedEmployees]", sqlParameters, MapEmployeeDetailsModel, 90);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public List<EmployeeModel> GetSearchedEmployee(string search)
        {
            try
            {
                var sqlParameters = new List<SqlParameter>();
                sqlParameters.Add(new SqlParameter("@SearchTerm", search));
                return this.ExecuteReader("[dbo].[SearchEmployee]", sqlParameters, MapEmployeeDetailsModel, 90);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int SaveEmployee(EmployeeModel employeeModel)
        {
            try
            {
                var sqlParameters = new List<SqlParameter>();
                sqlParameters.Add(new SqlParameter("@firstname", employeeModel.FirstName));
                sqlParameters.Add(new SqlParameter("@middlename", employeeModel.MiddleName));
                sqlParameters.Add(new SqlParameter("@lastname", employeeModel.LastName));
                sqlParameters.Add(new SqlParameter("@dob", employeeModel.DOB));
                sqlParameters.Add(new SqlParameter("@address1", employeeModel.Address1));
                sqlParameters.Add(new SqlParameter("@address2", employeeModel.Address2));
                sqlParameters.Add(new SqlParameter("@city", employeeModel.City));
                sqlParameters.Add(new SqlParameter("@state", employeeModel.State));
                sqlParameters.Add(new SqlParameter("@zipcode", employeeModel.ZipCode));
                sqlParameters.Add(new SqlParameter("@country", employeeModel.Country));
                sqlParameters.Add(new SqlParameter("@designation", employeeModel.Designation));
                sqlParameters.Add(new SqlParameter("@technology", employeeModel.Technology));
                sqlParameters.Add(new SqlParameter("@isActive", employeeModel.isActive));
                sqlParameters.Add(new SqlParameter("@created_by", employeeModel.UserId));
                sqlParameters.Add(new SqlParameter("@mobileno", employeeModel.MobileNo));
                return this.ExecuteNonQuery("[dbo].[SaveEmployee]", sqlParameters, 90);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public int UpdateEmployee(int id, EmployeeModel employeeModel)
        {
            try
            {
                var sqlParameters = new List<SqlParameter>();
                sqlParameters.Add(new SqlParameter("@eid", id));
                sqlParameters.Add(new SqlParameter("@firstname", employeeModel.FirstName));
                sqlParameters.Add(new SqlParameter("@middlename", employeeModel.MiddleName));
                sqlParameters.Add(new SqlParameter("@lastname", employeeModel.LastName));
                sqlParameters.Add(new SqlParameter("@dob", employeeModel.DOB));
                sqlParameters.Add(new SqlParameter("@address1", employeeModel.Address1));
                sqlParameters.Add(new SqlParameter("@address2", employeeModel.Address2));
                sqlParameters.Add(new SqlParameter("@city", employeeModel.City));
                sqlParameters.Add(new SqlParameter("@state", employeeModel.State));
                sqlParameters.Add(new SqlParameter("@zipcode", employeeModel.ZipCode));
                sqlParameters.Add(new SqlParameter("@country", employeeModel.Country));
                sqlParameters.Add(new SqlParameter("@designation", employeeModel.Designation));
                sqlParameters.Add(new SqlParameter("@technology", employeeModel.Technology));
                sqlParameters.Add(new SqlParameter("@mobileno", employeeModel.MobileNo));
                return this.ExecuteNonQuery("[dbo].[UpdateEmployee]", sqlParameters, 90);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int DeleteEmployee(int id)
        {
            try
            {
                var sqlParameters = new List<SqlParameter>();
                sqlParameters.Add(new SqlParameter("@eid", id));
                return this.ExecuteNonQuery("[dbo].[DeleteEmployee]", sqlParameters, 90);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        protected void MapEmployeeDetailsModel(EmployeeModel employeeDetails, SqlDataReader dataReader, string[] columnNameList)
        {
            int EmployeeIdIndex = this.GetColumnOrdinal(columnNameList, "eid");
            if (EmployeeIdIndex >= 0 && !dataReader.IsDBNull(EmployeeIdIndex))
            {
                employeeDetails.EmpId = dataReader.GetFieldValue<int>(EmployeeIdIndex);
            }


            int EmployeeFirstNameIndex = this.GetColumnOrdinal(columnNameList, "firstname");
            if (EmployeeFirstNameIndex >= 0 && !dataReader.IsDBNull(EmployeeFirstNameIndex))
            {
                employeeDetails.FirstName = dataReader.GetFieldValue<string>(EmployeeFirstNameIndex);
            }

            int EmployeeMiddleNameIndex = this.GetColumnOrdinal(columnNameList, "middlename");
            if (EmployeeMiddleNameIndex >= 0 && !dataReader.IsDBNull(EmployeeMiddleNameIndex))
            {
                employeeDetails.MiddleName = dataReader.GetFieldValue<string>(EmployeeMiddleNameIndex);
            }

            int EmployeeLastNameIndex = this.GetColumnOrdinal(columnNameList, "lastname");
            if (EmployeeLastNameIndex >= 0 && !dataReader.IsDBNull(EmployeeLastNameIndex))
            {
                employeeDetails.LastName = dataReader.GetFieldValue<string>(EmployeeLastNameIndex);
            }

            int EmployeeDOBIndex = this.GetColumnOrdinal(columnNameList, "dob");
            if (EmployeeDOBIndex >= 0 && !dataReader.IsDBNull(EmployeeDOBIndex))
            {
                employeeDetails.DOB = dataReader.GetFieldValue<DateTime>(EmployeeDOBIndex);
            }

            int EmployeeAddress1Index = this.GetColumnOrdinal(columnNameList, "address1");
            if (EmployeeAddress1Index >= 0 && !dataReader.IsDBNull(EmployeeAddress1Index))
            {
                employeeDetails.Address1 = dataReader.GetFieldValue<string>(EmployeeAddress1Index);
            }

            int EmployeeAddress2Index = this.GetColumnOrdinal(columnNameList, "address2");
            if (EmployeeAddress2Index >= 0 && !dataReader.IsDBNull(EmployeeAddress2Index))
            {
                employeeDetails.Address2 = dataReader.GetFieldValue<string>(EmployeeAddress2Index);
            }

            int EmployeeCityIndex = this.GetColumnOrdinal(columnNameList, "city");
            if (EmployeeCityIndex >= 0 && !dataReader.IsDBNull(EmployeeCityIndex))
            {
                employeeDetails.City = dataReader.GetFieldValue<string>(EmployeeCityIndex);
            }

            int EmployeeStateIndex = this.GetColumnOrdinal(columnNameList, "state");
            if (EmployeeStateIndex >= 0 && !dataReader.IsDBNull(EmployeeStateIndex))
            {
                employeeDetails.State = dataReader.GetFieldValue<string>(EmployeeStateIndex);
            }

            int EmployeeZipCodeIndex = this.GetColumnOrdinal(columnNameList, "zip_code");
            if (EmployeeZipCodeIndex >= 0 && !dataReader.IsDBNull(EmployeeZipCodeIndex))
            {
                employeeDetails.ZipCode = dataReader.GetFieldValue<int>(EmployeeZipCodeIndex);
            }

            int EmployeeCountryIndex = this.GetColumnOrdinal(columnNameList, "country");
            if (EmployeeCountryIndex >= 0 && !dataReader.IsDBNull(EmployeeCountryIndex))
            {
                employeeDetails.Country = dataReader.GetFieldValue<string>(EmployeeCountryIndex);
            }

            int EmployeeDesignationIndex = this.GetColumnOrdinal(columnNameList, "designation");
            if (EmployeeDesignationIndex >= 0 && !dataReader.IsDBNull(EmployeeDesignationIndex))
            {
                employeeDetails.Designation = dataReader.GetFieldValue<string>(EmployeeDesignationIndex);
            }

            int EmployeeTechnologyIndex = this.GetColumnOrdinal(columnNameList, "technology");
            if (EmployeeTechnologyIndex >= 0 && !dataReader.IsDBNull(EmployeeTechnologyIndex))
            {
                employeeDetails.Technology = dataReader.GetFieldValue<string>(EmployeeTechnologyIndex);
            }

            int EmployeeMobileIndex = this.GetColumnOrdinal(columnNameList, "mobileno");
            if (EmployeeMobileIndex >= 0 && !dataReader.IsDBNull(EmployeeMobileIndex))
            {
                employeeDetails.MobileNo = dataReader.GetFieldValue<string>(EmployeeMobileIndex);
            }


            int EmployeeIsActiveIndex = this.GetColumnOrdinal(columnNameList, "isActive");
            if (EmployeeIsActiveIndex >= 0 && !dataReader.IsDBNull(EmployeeIsActiveIndex))
            {
                employeeDetails.isActive = dataReader.GetFieldValue<bool>(EmployeeIsActiveIndex);
            }

            int UserIdIndex = this.GetColumnOrdinal(columnNameList, "created_by");
            if (UserIdIndex >= 0 && !dataReader.IsDBNull(UserIdIndex))
            {
                employeeDetails.UserId = dataReader.GetFieldValue<int>(UserIdIndex);
            }
        }
    }
}
