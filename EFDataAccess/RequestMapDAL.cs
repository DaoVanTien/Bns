using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFEntity;

namespace EFDataAccess
{
    public class RequestMapDAL
    {
        public List<tblRequestMap> AllRequest()
        {
            DBConnect db = new DBConnect();
            List<tblRequestMap> ListRequest = new List<tblRequestMap>();
            try 
	        {	        
		        var request = (from r in db.tblRequests
                              join c in db.tblCustomers
                              on r.CustomerID equals c.ID
                              join p in db.tblProducts
                              on r.ProductID equals p.ID
                              select new {r.ID, c.Name , p.ProductName, r.RequestID, r.RequestName}).ToList();
                foreach(var r in request)
                {
                    tblRequestMap req = new tblRequestMap();
                    req.ID = r.ID;
                    req.CustomerName = r.Name;
                    req.ProductName = r.ProductName;
                    req.RequestID = r.RequestID;
                    req.RequestName = r.RequestName;
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

        
        public tblRequestMap GetRequestByID(int id)
        {
            DBConnect db = new DBConnect();
            tblRequestMap req = new tblRequestMap();
            try
            {
                var request = (from r in db.tblRequests
                               join c in db.tblCustomers
                               on r.CustomerID equals c.ID
                               join p in db.tblProducts
                               on r.ProductID equals p.ID
                               where r.ID == id
                               select new { r.ID, c.Name, p.ProductName, r.RequestID, r.RequestName }).SingleOrDefault();
                
                    
                    req.ID = request.ID;
                    req.CustomerName = request.Name;
                    req.ProductName = request.ProductName;
                    req.RequestID = request.RequestID;
                    req.RequestName =request.RequestName;
                    
                
                db.Dispose();

            }
            catch (Exception ex)
            {
                db.Dispose();

            }
            return req;
        }
    }
}
