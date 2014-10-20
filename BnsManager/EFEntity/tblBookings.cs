using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
    public class tblBookings
    {
        [Key]
        public int ID { get; set; }
        public string BookingID { get; set; }
        public string BookingName { get; set; }
        public string Description { get; set; }
        public DateTime? Date_add { get; set; }
        public int ContractID { get; set; }
        public int EmployeeID { get; set; }
    }
}
