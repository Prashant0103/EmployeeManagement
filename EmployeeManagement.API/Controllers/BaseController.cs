using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EmployeeManagment.BAL.UOW;

namespace EmployeeManagement.API.Controllers
{
    public class BaseController : ApiController
    {
        protected static UnitOfWork UnitOfWorks = new UnitOfWork();
    }
}
