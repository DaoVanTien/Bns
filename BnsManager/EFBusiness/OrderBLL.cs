using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFEntity;
using EFDataAccess;

namespace EFBusiness
{
    public class OrderBLL
    {
        OrderDAL objOrderBLL = new OrderDAL();
        public int Insert(tblOrders Order)
        {
            return objOrderBLL.Insert(Order);
        }
    }
}
