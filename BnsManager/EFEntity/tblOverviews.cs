using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
    public class tblOverviews
    {
        public int ID { get; set; }
        public int? Requestid { get; set; }
        public string RequestID { get; set; }

        public int? Offerid { get; set; }
        public string OfferID {get;set;}

        public int? Orderid { get; set; }
        public string OrderID { get; set; }

        public int? Contractid { get; set; }
        public string ContractID { get; set; }

        public int? Invoiceid { get; set; }
        public string InvoiceID { get; set; }

        public int? Bookingid { get; set; }
        public string BookingID { get; set; }

       
    }
}
