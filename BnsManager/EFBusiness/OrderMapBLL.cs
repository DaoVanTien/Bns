using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFEntity;
using EFDataAccess;

namespace EFBusiness
{
    public class OrderMapBLL
    {
        OrderMapDAL objOrderMapBLL = new OrderMapDAL();
        // get by id
        public tblOrderMap OrderByID(int id)
        {
            return objOrderMapBLL.OrderByID(id);
        }
        //get all 
        public List<tblOrderMap> ListOrderAll()
        {
            return objOrderMapBLL.ListOrderAll();
        }
        //get by customer
        public List<tblOrderMap> ListOrderByCustomer(int id)
        {
            return objOrderMapBLL.ListOrderByCustomer(id);
        }
    }
}
