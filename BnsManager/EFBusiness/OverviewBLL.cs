using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFEntity;
using EFDataAccess;

namespace EFBusiness
{
    public class OverviewBLL
    {
        OverviewsDAL objOverviewBLL = new OverviewsDAL();
        public List<tblOverviews> ListAll()
        {
            return objOverviewBLL.ListAll();
        }
    }
}
