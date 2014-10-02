using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFEntity;

namespace EFDataAccess
{
    public class OrderDAL
    {
        public int Insert(tblOrders Order)
        { 
            DBConnect db = new DBConnect();
            try
            {
                db.tblOrders.Add(Order);
                db.SaveChanges();
                db.Dispose();
                return Order.ID;
            }
            catch (Exception ex)
            {
                db.Dispose();
                return 0;
            }
       
        }
    }
}
