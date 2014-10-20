using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFEntity;

namespace EFDataAccess
{
    public class InvoiceMapDAL
    {
        // list by contract
        public List<tblInvoiceMap> ListInvoiceByContract(int id)
        {
            DBConnect db = new DBConnect();
            List<tblInvoiceMap> ListInvoice = new List<tblInvoiceMap>();
            try
            {
                var invoices = (from i in db.tblInvoices
                                 join e in db.tblEmployees
                                 on i.EmployeeID equals e.ID
                                 join c in db.tblContracts
                                 on i.ContractID equals c.ID
                                 where c.ID == id
                                 select new { i.ID, i.InvoiceID, i.InvoiceName, i.Description, c.ContractName, e.EmployeeName}).ToList();
                foreach (var o in invoices)
                {
                    tblInvoiceMap invoice = new tblInvoiceMap();
                    invoice.ID = o.ID;
                    invoice.InvoiceID = o.InvoiceID;
                    invoice.InvoiceName = o.InvoiceName;
                    invoice.Description = o.Description;
                    invoice.ContractName = o.ContractName;
                    invoice.EmployeeName = o.EmployeeName;
                    ListInvoice.Add(invoice);
                }
                db.Dispose();

            }
            catch (Exception ex)
            {

                db.Dispose();

            }
            return ListInvoice;
        }
        // invoice by id
        public tblInvoiceMap InvoiceByID(int id)
        {
            DBConnect db = new DBConnect();
            tblInvoiceMap invoice = new tblInvoiceMap();
            try
            {
                var invoices = (from i in db.tblInvoices
                                join e in db.tblEmployees
                                on i.EmployeeID equals e.ID
                                join c in db.tblContracts
                                on i.ContractID equals c.ID
                                where i.ID == id
                                select new { i.ID, i.InvoiceID, i.InvoiceName, i.Description, c.ContractName, e.EmployeeName }).SingleOrDefault();
               
                    invoice.ID = invoices.ID;
                    invoice.InvoiceID = invoices.InvoiceID;
                    invoice.InvoiceName = invoices.InvoiceName;
                    invoice.Description = invoices.Description;
                    invoice.ContractName = invoices.ContractName;
                    invoice.EmployeeName = invoices.EmployeeName;
                    db.Dispose();
            }
            catch (Exception ex)
            {
                db.Dispose();
            }
            return invoice;
        }
    }
}
