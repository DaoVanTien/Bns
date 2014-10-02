using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFEntity;

namespace EFDataAccess
{
    public class OfferDAL
    {
        public int Insert(tblOffers Offer)
        {
            DBConnect db = new DBConnect();
            try
            {
                db.tblOffers.Add(Offer);
                db.SaveChanges();
                db.Dispose();
                return Offer.ID;
            }
            catch (Exception ex)
            {
                db.Dispose();
                return 0;
            }
        }
    }
}
