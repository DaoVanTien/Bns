using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFEntity;
using EFDataAccess;

namespace EFBusiness
{
    public class OfferMapBLL
    {
        OfferMapDAL objOfferMapBll = new OfferMapDAL();
        // all offer
        public List<tblOfferMap> ListOfferAll()
        {
            return objOfferMapBll.ListOfferAll();
        }
        // offer by customer
        public List<tblOfferMap> ListOfferByCustomer(int id)
        {
            return objOfferMapBll.ListOfferByCustomer(id);
        }
        // offer by id
        public tblOfferMap GetOfferByID(int id)
        {
            return objOfferMapBll.GetOfferByID(id);
        }
    }
}
