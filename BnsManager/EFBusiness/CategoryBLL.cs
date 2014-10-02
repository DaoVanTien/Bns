using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFEntity;
using EFDataAccess;

namespace EFBusiness
{
    public class CategoryBLL
    {
        CategoryDAL objCategoryBLL = new CategoryDAL();
        public List<tblCategory> ListCategoryAll()
        {
            return objCategoryBLL.ListCategoryAll();
        }
    }
}
