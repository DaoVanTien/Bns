using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFEntity;

namespace EFDataAccess
{
    public class BookingMapDAL
    {
        // list by contract
        public List<tblBookingMap> ListBookingByContract(int id)
        {
            DBConnect db = new DBConnect();
            List<tblBookingMap> ListBooking = new List<tblBookingMap>();
            try
            {
                var bookings = (from b in db.tblBookings
                                join e in db.tblEmployees
                                on b.EmployeeID equals e.ID
                                join c in db.tblContracts
                                on b.ContractID equals c.ID
                                where c.ID == id
                                select new { b.ID, b.BookingID, b.BookingName, b.Description,  b.Date_add, c.ContractName, e.EmployeeName }).ToList();
                foreach (var b in bookings)
                {
                    tblBookingMap booking = new tblBookingMap();
                    booking.ID = b.ID;
                    booking.BookingID = b.BookingID;
                    booking.BookingName = b.BookingName;
                    booking.Description = b.Description;
                    booking.Date_add = b.Date_add;
                    booking.ContractName = b.ContractName;
                    booking.EmployeeName = b.EmployeeName;
                    ListBooking.Add(booking);
                }
                db.Dispose();

            }
            catch (Exception ex)
            {

                db.Dispose();

            }
            return ListBooking;
        }
        // invoice by id
        public tblBookingMap BookingByID(int id)
        {
            DBConnect db = new DBConnect();
            tblBookingMap booking = new tblBookingMap();
            try
            {
                var bookings = (from i in db.tblBookings
                                join e in db.tblEmployees
                                on i.EmployeeID equals e.ID
                                join c in db.tblContracts
                                on i.ContractID equals c.ID
                                where i.ID == id
                                select new { i.ID, i.BookingID, i.BookingName, i.Description, i.Date_add, c.ContractName, e.EmployeeName }).SingleOrDefault();

                booking.ID = bookings.ID;
                booking.BookingID = bookings.BookingID;
                booking.BookingName = bookings.BookingName;
                booking.Description = bookings.Description;
                booking.Date_add = bookings.Date_add;
                booking.ContractName = bookings.ContractName;
                booking.EmployeeName = bookings.EmployeeName;
                db.Dispose();
            }
            catch (Exception ex)
            {
                db.Dispose();
            }
            return booking;
        }
    }
}
