using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFEntity;
using EFDataAccess;

namespace EFBusiness
{
    public class RequestMapBLL
    {
        RequestMapDAL objRequestBLL = new RequestMapDAL();
        public List<tblRequestMap> AllRequest()
        {
            return objRequestBLL.AllRequest();
        }
        public tblRequestMap GetRequestByID(int id)
        {
            return objRequestBLL.GetRequestByID(id);
        }

    }
}
