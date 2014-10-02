using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFEntity;

namespace EFDataAccess
{
    public class CustomerDAL
    {
        // get all customer
        public List<tblCustomers> ListCustomerALl()
        {
            DBConnect db = new DBConnect();
            List<tblCustomers> ListCustomer = new List<tblCustomers>();
            try
            {
                var cus = (from p in db.tblCustomers
                           select p).ToList();
                foreach (var n in cus)
                {
                    tblCustomers customer = new tblCustomers();
                    customer.ID = n.ID;
                    customer.CustomerID = n.CustomerID;
                    customer.Name = n.Name;
                    customer.Address1 = n.Address1;
                    customer.Address2 = n.Address2;
                    customer.Website = n.Website;
                    customer.Phone1 = n.Phone1;
                    customer.Phone2 = n.Phone2;
                    customer.Email = n.Email;
                    customer.Fax = n.Fax;
                    customer.Job_position = n.Job_position;
                    customer.Notes = n.Notes;
                    customer.visible = n.visible;
                    ListCustomer.Add(customer);
                }
                db.Dispose();
            }
            catch (Exception ex)
            {
                db.Dispose();  
            }
            return ListCustomer;
        }
        // add new customer
        public int Insert(tblCustomers customer)
        {
            DBConnect db = new DBConnect();
            try
            {
                db.tblCustomers.Add(customer);
                db.SaveChanges();
                return customer.ID;
            }
            catch (Exception ex)
            {
                db.Dispose();
                return 0;
            }
        }
        //delete customer
        public bool Delete(int ID)
        {
            DBConnect db = new DBConnect();
            try
            {
                var cus = db.tblCustomers.Find(ID);
                if (cus != null)
                {
                    db.tblCustomers.Remove(cus);
                    db.SaveChanges();
                    db.Dispose();
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                db.Dispose();
                return false;
            }
        }
        //update custommer
        public bool Update(tblCustomers customer)
        {
            DBConnect db = new DBConnect();
            try
            {
                var cus = db.tblCustomers.Find(customer.ID);
                if (cus != null)
                { 
                    cus.CustomerID = customer.CustomerID;
                    cus.Name = customer.Name;
                    cus.Address1 = customer.Address1;
                    cus.Address2 = customer.Address2;
                    cus.Website = customer.Website;
                    cus.Phone1 = customer.Phone1;
                    cus.Phone2 = customer.Phone2;
                    cus.Email = customer.Email;
                    cus.Fax = customer.Fax;
                    cus.Job_position = customer.Job_position;
                    cus.Notes = customer.Notes;
                    cus.visible = customer.visible;
                    db.SaveChanges();
                    db.Dispose();
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                db.Dispose();
                return false;
            }
        }

        //get customer by id
        public tblCustomers GetCustomerByID(int ID)
        {
            DBConnect db = new DBConnect();
            return db.tblCustomers.SingleOrDefault(c => c.ID == ID);
        }
    }
}
