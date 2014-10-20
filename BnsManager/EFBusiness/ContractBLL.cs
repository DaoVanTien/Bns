using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFEntity;
using EFDataAccess;

namespace EFBusiness
{
    public class ContractBLL
    {
        ContractDAL objContractBLL = new ContractDAL();
        public int Insert(tblContracts Contract)
        {
            return objContractBLL.Insert(Contract);
        }
    }
}
