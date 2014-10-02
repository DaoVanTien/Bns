using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFEntity;

namespace EFDataAccess
{
    public class OrderMapDAL
    {
        // list all
        public List<tblOrderMap> ListOrderAll()
        {
            DBConnect db = new DBConnect();
            List<tblOrderMap> ListOrder = new List<tblOrderMap>();
            try
            {
                var orders = (from o in db.tblOrders
                              join e in db.tblEmployees
                              on o.EmployeeID equals e.ID
                              join r in db.tblRequests
                              on o.RequestID equals r.ID
                              join c in db.tblCustomers
                              on r.CustomerID equals c.ID
                              join p in db.tblProducts
                              on r.ProductID equals p.ID
                              select new { o.ID, e.EmployeeName, c.Name, p.ProductName, o.OrderID, o.OrderName }).ToList();
                foreach (var o in orders)
                {
                    tblOrderMap offer = new tblOrderMap();
                    offer.ID = o.ID;
                    offer.EmployeeName = o.EmployeeName;
                    offer.CustomerName = o.Name;
                    offer.ProductName = o.ProductName;
                    offer.OrderID = o.OrderID;
                    offer.OrderName = o.OrderName;
                    ListOrder.Add(offer);
                }
                db.Dispose();

            }
            catch (Exception ex)
            {

                db.Dispose();

            }
            return ListOrder;
        }

        // list by customer
        public List<tblOrderMap> ListOrderByCustomer(int id)
        {
            DBConnect db = new DBConnect();
            List<tblOrderMap> ListOrder = new List<tblOrderMap>();
            try
            {
                var orders = (from o in db.tblOrders
                              join e in db.tblEmployees
                              on o.EmployeeID equals e.ID
                              join r in db.tblRequests
                              on o.RequestID equals r.ID
                              join c in db.tblCustomers
                              on r.CustomerID equals c.ID
                              join p in db.tblProducts
                              on r.ProductID equals p.ID
                              where c.ID == id
                              select new { o.ID, e.EmployeeName, c.Name, p.ProductName, o.OrderID, o.OrderName }).ToList();
                foreach (var o in orders)
                {
                    tblOrderMap offer = new tblOrderMap();
                    offer.ID = o.ID;
                    offer.EmployeeName = o.EmployeeName;
                    offer.CustomerName = o.Name;
                    offer.ProductName = o.ProductName;
                    offer.OrderID = o.OrderID;
                    offer.OrderName = o.OrderName;
                    ListOrder.Add(offer);
                }
                db.Dispose();

            }
            catch (Exception ex)
            {

                db.Dispose();

            }
            return ListOrder;
        }
        // get by id
        public tblOrderMap OrderByID(int id)
        {
            DBConnect db = new DBConnect();
            tblOrderMap Order  = new tblOrderMap();
            try
            {
                var orders = (from o in db.tblOrders
                              join e in db.tblEmployees
                              on o.EmployeeID equals e.ID
                              join r in db.tblRequests
                              on o.RequestID equals r.ID
                              join c in db.tblCustomers
                              on r.CustomerID equals c.ID
                              join p in db.tblProducts
                              on r.ProductID equals p.ID
                              where o.ID == id
                              select new { o.ID, e.EmployeeName, c.Name, p.ProductName, o.OrderID, o.OrderName }).SingleOrDefault();
                Order.ID = orders.ID;
                Order.EmployeeName = orders.EmployeeName;
                Order.CustomerName = orders.Name;
                Order.ProductName = orders.ProductName;
                Order.OrderID = orders.OrderID;
                Order.OrderName = orders.OrderName;
                db.Dispose();
                    
                    
            }
            catch (Exception ex)
            {
                db.Dispose();
            }
            return Order;
        }

    }
}
