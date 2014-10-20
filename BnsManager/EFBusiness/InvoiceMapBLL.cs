using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFEntity;
using EFDataAccess;

namespace EFBusiness
{
    public class InvoiceMapBLL
    {
        InvoiceMapDAL objInvoiceMapBLL = new InvoiceMapDAL();
        public List<tblInvoiceMap> ListInvoiceByContract(int id)
        {
            return objInvoiceMapBLL.ListInvoiceByContract(id);
        }
        public tblInvoiceMap InvoiceByID(int id)
        {
            return objInvoiceMapBLL.InvoiceByID(id);
        }
    }
}
