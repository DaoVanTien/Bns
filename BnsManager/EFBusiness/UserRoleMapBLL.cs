using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFEntity;
using EFDataAccess;

namespace EFBusiness
{
    public class UserRoleMapBLL
    {
        UserRoleMap objUserRoleMapBLL = new UserRoleMap();
        // get Role by email
        public string GetRoleByEmail(string email)
        {
            return objUserRoleMapBLL.GetRoleByEmail(email);
        }
    }
}
