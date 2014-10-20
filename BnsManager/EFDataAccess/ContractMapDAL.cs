using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFEntity;

namespace EFDataAccess
{
    public class ContractMapDAL
    {
        // list all
        public List<tblContractMap> ListContractrAll()
        {
            DBConnect db = new DBConnect();
            List<tblContractMap> ListContract = new List<tblContractMap>();
            try
            {
                var contracts = (from o in db.tblContracts
                              join e in db.tblEmployees
                              on o.EmployeeID equals e.ID
                              join ord in db.tblOrders
                              on o.OrderID equals ord.ID
                              join off in db.tblOffers
                              on ord.OfferID equals off.ID
                              join r in db.tblRequests
                              on off.RequestID equals r.ID
                              join cus in db.tblCustomers
                              on r.CustomerID equals cus.ID
                              join pro in db.tblProducts
                              on r.ProductID equals pro.ID
                              select new { o.ID, e.EmployeeName, cus.Name, pro.ProductName, o.ContractID, o.ContractName }).ToList();
                foreach (var o in contracts)
                {
                    tblContractMap contract = new tblContractMap();
                    contract.ID = o.ID;
                    contract.EmployeeName = o.EmployeeName;
                    contract.CustomerName = o.Name;
                    contract.ProductName = o.ProductName;
                    contract.ContractID = o.ContractID;
                    contract.ContractName = o.ContractName;
                    ListContract.Add(contract);
                }
                db.Dispose();

            }
            catch (Exception ex)
            {
                db.Dispose();

            }
            return ListContract;
        }

        // list by customer
        public List<tblContractMap> ListContractByCustomer(int id)
        {
            DBConnect db = new DBConnect();
            List<tblContractMap> ListContract = new List<tblContractMap>();
            try
            {
                var contracts = (from o in db.tblContracts
                                 join e in db.tblEmployees
                                 on o.EmployeeID equals e.ID
                                 join ord in db.tblOrders
                                 on o.OrderID equals ord.ID
                                 join off in db.tblOffers
                                 on ord.OfferID equals off.ID
                                 join r in db.tblRequests
                                 on off.RequestID equals r.ID
                                 join cus in db.tblCustomers
                                 on r.CustomerID equals cus.ID
                                 join pro in db.tblProducts
                                 on r.ProductID equals pro.ID
                                 where cus.ID == id
                                 select new { o.ID, e.EmployeeName, cus.Name, pro.ProductName, o.ContractID, o.ContractName }).ToList();
                foreach (var o in contracts)
                {
                    tblContractMap contract = new tblContractMap();
                    contract.ID = o.ID;
                    contract.EmployeeName = o.EmployeeName;
                    contract.CustomerName = o.Name;
                    contract.ProductName = o.ProductName;
                    contract.ContractID = o.ContractID;
                    contract.ContractName = o.ContractName;
                    ListContract.Add(contract);
                }
                db.Dispose();

            }
            catch (Exception ex)
            {

                db.Dispose();

            }
            return ListContract;
        }
        // get by id
        public tblContractMap ContractByID(int id)
        {
            DBConnect db = new DBConnect();
            tblContractMap Contract = new tblContractMap();
            try
            {
                var contracts = (from o in db.tblContracts
                                 join e in db.tblEmployees
                                 on o.EmployeeID equals e.ID
                                 join ord in db.tblOrders
                                 on o.OrderID equals ord.ID
                                 join off in db.tblOffers
                                 on ord.OfferID equals off.ID
                                 join r in db.tblRequests
                                 on off.RequestID equals r.ID
                                 join cus in db.tblCustomers
                                 on r.CustomerID equals cus.ID
                                 join pro in db.tblProducts
                                 on r.ProductID equals pro.ID
                                 where o.ID == id
                                 select new { o.ID, e.EmployeeName, cus.Name, pro.ProductName, o.ContractID, o.ContractName }).SingleOrDefault();
                Contract.ID = contracts.ID;
                Contract.EmployeeName = contracts.EmployeeName;
                Contract.CustomerName = contracts.Name;
                Contract.ProductName = contracts.ProductName;
                Contract.ContractID = contracts.ContractID;
                Contract.ContractName = contracts.ContractName;
                db.Dispose();


            }
            catch (Exception ex)
            {
                db.Dispose();
            }
            return Contract;
        }

    }
}
