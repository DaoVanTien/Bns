using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EFEntity
{
    public class tblBookingMap
    {
        [Key]
        public int ID { get; set; }
        public string BookingID { get; set; }
        public string BookingName { get; set; }
        public string Description { get; set; }
        public DateTime? Date_add { get; set; }
        public string ContractName { get; set; }
        public string EmployeeName { get; set; }
    }
}
