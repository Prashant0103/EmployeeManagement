﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.DAL.UOW;

namespace EmployeeManagment.BAL.Services
{
    public class BaseService
    {
        protected static UnitOfWork UnitOfWorks = new UnitOfWork();
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
