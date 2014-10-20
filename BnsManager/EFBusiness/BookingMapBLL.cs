using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFEntity;
using EFDataAccess;

namespace EFBusiness
{
    public class BookingMapBLL
    {
        BookingMapDAL objBookingMapBll = new BookingMapDAL();
        public List<tblBookingMap> ListBookingByContract(int id)
        {
            return objBookingMapBll.ListBookingByContract(id);
        }
        public tblBookingMap BookingByID(int id)
        {
            return objBookingMapBll.BookingByID(id);
        }
    }
}
