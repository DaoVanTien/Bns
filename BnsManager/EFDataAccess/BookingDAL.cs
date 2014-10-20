using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFEntity;

namespace EFDataAccess
{
    public class BookingDAL
    {
        public int Insert(tblBookings Booking)
        {
            DBConnect db = new DBConnect();
            try
            {
                db.tblBookings.Add(Booking);
                db.SaveChanges();
                db.Dispose();
                return Booking.ID;
            }
            catch (Exception ex)
            {
                db.Dispose();
                return 0;
            }
        }
    }
}
