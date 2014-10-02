using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFEntity;
using EFDataAccess;
namespace EFBusiness
{
    public class Product_To_CategoryBLL
    {
        Product_To_CategoryDAL objProduct_To_CategoryBLL = new Product_To_CategoryDAL();
        public int Insert(tblProduct_To_Category productToCategory)
        {
            return objProduct_To_CategoryBLL.Insert(productToCategory);
        }
    }
}
