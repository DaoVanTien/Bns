using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFEntity;
using EFDataAccess;

namespace EFBusiness
{
    public class RequestBLL
    {
        RequestDAL objRequestBLL = new RequestDAL();
        public int Insert(tblRequests Request)
        {
            return objRequestBLL.Insert(Request);
        }
    }
}
