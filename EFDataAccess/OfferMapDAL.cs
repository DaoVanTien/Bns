using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFEntity;

namespace EFDataAccess
{
    public class OfferMapDAL
    {
        // list offer
        public List<tblOfferMap> ListOfferAll()
        {
            DBConnect db = new DBConnect();
            List<tblOfferMap> ListOffer = new List<tblOfferMap>();
            try
            {
                var offers = (from o in db.tblOffers
                             join e in db.tblEmployees
                             on o.EmployeeID equals e.ID
                             join r in db.tblRequests
                             on o.RequestID equals r.ID
                             join c in db.tblCustomers
                             on r.CustomerID equals c.ID
                             join p in db.tblProducts
                             on r.ProductID equals p.ID
                             select new { o.ID, e.EmployeeName, c.Name, p.ProductName, o.OfferID, o.OfferName }).ToList();
                foreach (var o in offers)
                {
                    tblOfferMap offer = new tblOfferMap();
                    offer.ID = o.ID;
                    offer.EmployeeName = o.EmployeeName;
                    offer.CustomerName = o.Name;
                    offer.ProductName = o.ProductName;
                    offer.OfferID = o.OfferID;
                    offer.OfferName = o.OfferName;
                    ListOffer.Add(offer);
                }
                db.Dispose();

            }
            catch (Exception ex)
            {

                db.Dispose();
               
            }
            return ListOffer;
        }
        // offer by  id
        public tblOfferMap GetOfferByID(int id)
        {
            DBConnect db = new DBConnect();
            tblOfferMap offernew = new tblOfferMap();
            try
            {
                var offer = (from o in db.tblOffers
                             join e in db.tblEmployees
                             on o.EmployeeID equals e.ID
                             join r in db.tblRequests
                             on o.RequestID equals r.ID
                             join c in db.tblCustomers
                             on r.CustomerID equals c.ID
                             join p in db.tblProducts
                             on r.ProductID equals p.ID
                             where o.ID == id
                             select new { o.ID, e.EmployeeName, c.Name, p.ProductName, o.OfferID, o.OfferName }).SingleOrDefault();
                offernew.ID = offer.ID;
                offernew.EmployeeName = offer.EmployeeName;
                offernew.CustomerName = offer.Name;
                offernew.ProductName = offer.ProductName;
                offernew.OfferID = offer.OfferID;
                offernew.OfferName = offer.OfferName;
                db.Dispose();
            }
            catch (Exception ex)
            {
                db.Dispose();
            }
            return offernew;
        }

        // offer by customer
        public List<tblOfferMap> ListOfferByCustomer(int id)
        {
            DBConnect db = new DBConnect();
            List<tblOfferMap> ListOffer = new List<tblOfferMap>();
            try
            {
                var offers = (from o in db.tblOffers
                              join e in db.tblEmployees
                              on o.EmployeeID equals e.ID
                              join r in db.tblRequests
                              on o.RequestID equals r.ID
                              join c in db.tblCustomers
                              on r.CustomerID equals c.ID
                              join p in db.tblProducts
                              on r.ProductID equals p.ID
                              where c.ID == id
                              select new { o.ID, e.EmployeeName, c.Name, p.ProductName, o.OfferID, o.OfferName }).ToList();
                foreach (var o in offers)
                {
                    tblOfferMap offer = new tblOfferMap();
                    offer.ID = o.ID;
                    offer.EmployeeName = o.EmployeeName;
                    offer.CustomerName = o.Name;
                    offer.ProductName = o.ProductName;
                    offer.OfferID = o.OfferID;
                    offer.OfferName = o.OfferName;
                    ListOffer.Add(offer);
                }
                db.Dispose();

            }
            catch (Exception ex)
            {

                db.Dispose();

            }
            return ListOffer;
        }
    }
}
