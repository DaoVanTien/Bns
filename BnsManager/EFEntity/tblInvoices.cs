using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
    public class tblInvoices
    {
        [Key]
        public int ID {get;set; }
        public string InvoiceID {get;set; }
        public string InvoiceName {get;set; }
        public string Description {get;set; }
        public int ContractID { get; set; }
        public int EmployeeID { get; set; }
    }
}
