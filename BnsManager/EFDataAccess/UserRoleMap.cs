using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFEntity;

namespace EFDataAccess
{
    public class UserRoleMap
    {
        // get role by user email
        public string GetRoleByEmail(string email)
        {
            DBConnect db = new DBConnect();
            string role = null;
            var data = (from e in db.tblEmployees
                        join er in db.tblUserRole
                        on e.ID equals er.EmployeeID
                        join r in db.tblRoles
                        on er.RoleID equals r.RoleID
                        where e.Email == email
                        select r.RoleName).FirstOrDefault();
            if (data != null)
            {
                role = data.ToString();
            }
            return role;
        }
        
    }
}
