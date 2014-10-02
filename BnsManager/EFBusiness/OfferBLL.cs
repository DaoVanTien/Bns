using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFEntity;
using EFDataAccess;

namespace EFBusiness
{
    public class OfferBLL
    {
        OfferDAL objOfferBLL = new OfferDAL();
        public int Insert(tblOffers Offer)
        {
            return objOfferBLL.Insert(Offer);
        }
    }
}
