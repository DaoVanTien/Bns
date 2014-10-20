using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFEntity;
using EFDataAccess;

namespace EFBusiness
{
    public class ContractMapBLL
    {
        ContractMapDAL objContractMapBLL = new ContractMapDAL();
        public List<tblContractMap> ListContractrAll()
        {
            return objContractMapBLL.ListContractrAll();
        }
        public List<tblContractMap> ListContractByCustomer(int id)
        {
            return objContractMapBLL.ListContractByCustomer(id);
        }
        public tblContractMap ContractByID(int id)
        {
            return objContractMapBLL.ContractByID(id);
        }
    }
}
