using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFDataAccess;
using EFEntity;

namespace EFBusiness
{
    public class InvoiceBLL
    {
        InvoiceDAL objInvoiceBLL = new InvoiceDAL();
        public int Insert(tblInvoices Invoice)
        {
            return objInvoiceBLL.Insert(Invoice);
        }
    }
}
