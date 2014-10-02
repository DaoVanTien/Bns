using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFEntity;

namespace EFDataAccess
{
    public class RequestDAL
    {
        public int Insert(tblRequests Request)
        {
            DBConnect db = new DBConnect();
            try
            {
                db.tblRequests.Add(Request);
                db.SaveChanges();
                db.Dispose();
                return Request.ID;
            }
            catch (Exception ex)
            {
                db.Dispose();
                return 0;
            }
        }

        public List<tblRequests> ListOrderAll()
        {
            DBConnect db = new DBConnect();
            List<tblRequests> ListRequest = new List<tblRequests>();
            try
            {
                var request = (from o in db.tblRequests
                             select o).ToList();
                foreach (var o in request)
                {
                    tblRequests req = new tblRequests();
                    req.ID = o.ID;
                    req.CustomerID = o.CustomerID;
                    req.ProductID = o.ProductID;
                    req.RequestID = o.RequestID;
                    req.RequestName = o.RequestName;
                    ListRequest.Add(req);
                }
                db.Dispose();
            }
            catch (Exception ex)
            {
                db.Dispose();
                
            }
            return ListRequest;
        }
        
        
    }
}
