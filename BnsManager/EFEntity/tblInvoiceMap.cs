using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EFEntity
{
    public class tblInvoiceMap
    {
        [Key]
        public int ID { get; set; }
        public string InvoiceID { get; set; }
        public string InvoiceName { get; set; }
        public string Description { get; set; }
        public string ContractName { get; set; }
        public string EmployeeName { get; set; }
    }
}
