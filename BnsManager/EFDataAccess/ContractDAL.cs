using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFEntity;

namespace EFDataAccess
{
    public class ContractDAL
    {
        public int Insert(tblContracts Contract)
        {
            DBConnect db = new DBConnect();
            try
            {
                db.tblContracts.Add(Contract);
                db.SaveChanges();
                db.Dispose();
                return Contract.ID;
            }
            catch (Exception ex)
            {
                db.Dispose();
                return 0;
            }

        }
    }
}
