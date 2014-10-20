using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFEntity;

namespace EFDataAccess
{
    public class OverviewsDAL
    {
        public List<tblOverviews> ListAll()
        {
            DBConnect db = new DBConnect();
            List<tblOverviews> ListOverviews = new List<tblOverviews>();
            try
            {
                //var overviews = (from re in db.tblRequests
                //              join of in db.tblOffers
                //              on re.ID equals of.RequestID
                //              join ord in db.tblOrders
                //              on re.ID equals ord.RequestID
                //              join contr in db.tblContracts
                //              on re.ID equals contr.RequestID
                //              join inv in db.tblInvoices
                //              on contr.ID equals inv.ContractID
                //              join book in db.tblBookings
                //              on contr.ID equals book.ContractID
                //              select new { Requestid = re.ID, re.RequestID,
                //                          Offerid = of.ID, OfferId = of.OfferID,
                //                          Orderid = ord.ID, ord.OrderID, 
                //                          Contractid = contr.ID, contr.ContractID,
                //                          Invoiceid = inv.ID , inv.InvoiceID,
                //                          Bookingid = book.ID, book.BookingID
                //                          }).ToList();

                var overviews = (from re in db.tblRequests

                                 join of in db.tblOffers
                                 on re.ID equals of.RequestID into re_of

                                 from a in re_of.DefaultIfEmpty()
                                 join ord in db.tblOrders
                                 on a.ID equals ord.OfferID into re_ord

                                 from b in re_ord.DefaultIfEmpty()
                                 join contr in db.tblContracts
                                 on b.ID equals contr.OrderID into re_contr

                                 from c in re_contr.DefaultIfEmpty()
                                 join inv in db.tblInvoices
                                 on c.ID equals inv.ContractID into inv_cont

                                 from d in inv_cont.DefaultIfEmpty()
                                 join book in db.tblBookings
                                 on c.ID equals book.ContractID into book_cont
                                 from e in book_cont.DefaultIfEmpty()


                                 select new
                                 {
                                     Requestid = (int?)re.ID,
                                     re.RequestID,
                                     Offerid = (int?)a.ID,
                                     OfferId = a.OfferID,
                                     Orderid = (int?)b.ID,
                                     b.OrderID,
                                     Contractid = (int?)c.ID,
                                     c.ContractID,
                                     Invoiceid = (int?)d.ID,
                                     d.InvoiceID,
                                     Bookingid = (int?)e.ID,
                                     e.BookingID
                                     

                                 }).ToList();
                int count = 0;
                foreach (var over in overviews)
                {
                    count += 1;
                    tblOverviews overview = new tblOverviews();
                    overview.ID = count;
                    overview.Requestid = over.Requestid;
                    overview.RequestID = over.RequestID;

                    overview.Offerid = over.Offerid;
                    overview.OfferID = over.OfferId;

                    overview.Orderid = over.Orderid;
                    overview.OrderID = over.OrderID;

                    overview.Contractid = over.Contractid;
                    overview.ContractID = over.ContractID;

                    overview.Invoiceid = over.Invoiceid;
                    overview.InvoiceID = over.InvoiceID;

                    overview.Bookingid = over.Bookingid;
                    overview.BookingID = over.BookingID;

                    ListOverviews.Add(overview);
                }
                db.Dispose();
            }
            catch (Exception ex)
            {

                db.Dispose();

            }
            return ListOverviews;
        }
    }
}
