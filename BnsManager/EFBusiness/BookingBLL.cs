using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFEntity;
using EFDataAccess;

namespace EFBusiness
{
    public class BookingBLL
    {
        BookingDAL objBookingBll = new BookingDAL();
        public int Insert(tblBookings Booking)
        {
            return objBookingBll.Insert(Booking);
        }
    }
}
