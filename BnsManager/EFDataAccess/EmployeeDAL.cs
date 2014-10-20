using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFEntity;

namespace EFDataAccess
{
    public class EmployeeDAL
    {
        //insert
        public int Insert(tblEmployees Employee)
        {
            DBConnect db = new DBConnect();
            try
            {
                db.tblEmployees.Add(Employee);
                db.SaveChanges();
                db.Dispose();
                return Employee.ID ;
            }
            catch (Exception ex)
            {
                db.Dispose();
                return 0;
            }

        }
        // Get user email pass
        public tblEmployees GetEmployeeByEP(string Email, string Password)
        {
            DBConnect db = new DBConnect();
            return db.tblEmployees.SingleOrDefault(e => e.Email == Email && e.Password == Password);
        }
        // check login
        public bool checkLogin(string email, string password)
        {
            DBConnect db = new DBConnect();
            bool ok = false;
            try 
	        {
                var login = db.tblEmployees.Where(e => e.Email.Equals(email) && e.Password.Equals(password)).FirstOrDefault();
                if (login != null)
                    ok = true;
                db.Dispose();	        }
	        catch (Exception)
	        {
                db.Dispose();
	        }
            return ok;
        }



    }
}
