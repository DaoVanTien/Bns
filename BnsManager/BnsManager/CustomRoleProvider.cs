using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using EFEntity;
using EFBusiness;

namespace BnsManager
{
    public class CustomRoleProvider:RoleProvider
    {
        UserRoleMapBLL objUserRoleMap = new UserRoleMapBLL();
        public override string[] GetRolesForUser(string email)
        {
            var data = objUserRoleMap.GetRoleByEmail(email);
            if (data != null)
            {
                return new string[] { data };

            }
            else
                return new string[] { };
        }
        //ham nay khong can thiet
        public override bool IsUserInRole(string username, string roleName)
        {
            if (username.Equals("tiendao.online@gmail.com") && roleName.Equals("giaovien"))
            {
                return true;
            }
            else if (username.Equals("tiendao.online@gmail.com") && roleName.Equals("giaovu"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override string ApplicationName
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }

        public override string[] GetAllRoles()
        {
            throw new NotImplementedException();
        }

        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }



        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }
    }
}