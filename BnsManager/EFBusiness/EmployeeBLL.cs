using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFEntity;
using EFDataAccess;

namespace EFBusiness
{
    public class EmployeeBLL
    {
        EmployeeDAL objEmployeeBLL = new EmployeeDAL();
        //insert
        public int Insert(tblEmployees Employee)
        {
            return objEmployeeBLL.Insert(Employee);
        }
        // get u by email pass
        public tblEmployees GetEmployeeByEP(string Email, string Password)
        {
            return objEmployeeBLL.GetEmployeeByEP(Email, Password);
        }
        // check login
        public bool checkLogin(string email, string password)
        {
            return objEmployeeBLL.checkLogin(email, password);
        }
    }
}
