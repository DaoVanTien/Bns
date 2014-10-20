using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFEntity;

namespace EFDataAccess
{
    public class InvoiceDAL
    {
        // insert
        public int Insert(tblInvoices Invoice)
        {
            DBConnect db = new DBConnect();
            try
            {
                db.tblInvoices.Add(Invoice);
                db.SaveChanges();
                db.Dispose();
                return Invoice.ID;
            }
            catch (Exception ex)
            {
                db.Dispose();
                return 0;
            }
        }
        
        
    }
}
