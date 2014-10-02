using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFEntity;
using EFDataAccess;

namespace EFBusiness
{
    public class CustomerBLL
    {
        CustomerDAL objCustomerBLL = new CustomerDAL();
        //get all customer
        public List<tblCustomers> ListCustomerALl()
        {
            return objCustomerBLL.ListCustomerALl();
        }
        //add new customer
        public int Insert(tblCustomers customer)
        {
            return objCustomerBLL.Insert(customer);
        }
        // update
        public bool Update(tblCustomers customer)
        {
            return objCustomerBLL.Update(customer);
        }
        //delete
        public bool Delete(int ID)
        {
            return objCustomerBLL.Delete(ID);
        }
        //get by id
        public tblCustomers GetCustomerByID(int ID)
        {
            return objCustomerBLL.GetCustomerByID(ID);
        }
    }
}
